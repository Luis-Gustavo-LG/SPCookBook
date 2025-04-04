using SPCookBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCookBook
{
    public partial class ReceitaUC : UserControl
    {
        public ReceitaUC()
        {
            InitializeComponent();
        }

        public UsuarioReceita Receita { get; set; }

        public bool IsFavorito { get; set; }

        public event EventHandler ReceitaDesfavoritada;

        public string Nome
        {
            get => lblNome.Text;
            set => lblNome.Text = value;
        }

        public int Tempo
        {
            get => int.TryParse(lblTempo.Text.Replace(" Min", ""), out int value) ? value : 0;
            set => lblTempo.Text = $"{value} Min";
        }

        public Image Foto
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public Image Favorito
        {
            get => picboxFavoritar.Image;
            set => picboxFavoritar.Image = value;
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private T FindParentControl<T>(Control control) where T : Control
        {
            while (control != null)
            {
                if (control is T)
                    return (T)control;

                control = control.Parent;
            }
            return null;
        }

        private void picboxFavoritar_Click(object sender, EventArgs e)
        {
            using(var ctx = new SPCookbookEntities())
            {
                if(sender is PictureBox picbox)
                {
                    ReceitaUC receitaUC = FindParentControl<ReceitaUC>(this);
                    if (receitaUC == null)
                    {
                        MessageBox.Show("Erro ao encontrar o controle ReceitaUC.");
                        return;
                    }

                    var receita = receitaUC.Receita;

                    if (receita == null)
                    {
                        MessageBox.Show("Receita não encontrada.");
                        return;
                    }


                    // Verifica se a receita já foi favoritada pelo usuário
                    var receitaFavorita = ctx.ReceitaFavorira
            .FirstOrDefault(rf => rf.UsuarioID == UsuarioLogado.CurrentUser.id && rf.ReceitaID == receita.id);

                    if (receitaFavorita != null)
                        {
                            // Se a receita já estiver favoritada, desfavorita (remove do banco)
                            ctx.ReceitaFavorira.Remove(receitaFavorita);
                            picboxFavoritar.Image = ByteArrayToImage(Resource1.naofavoritado);                           
                            MessageBox.Show("Receita removida dos favoritos.");
                            ReceitaDesfavoritada?.Invoke(sender, EventArgs.Empty);
                    }
                        else
                        {
                            // Caso contrário, adiciona como favorita
                            var novaReceitaFavorita = new ReceitaFavorira
                            {
                                UsuarioID = UsuarioLogado.CurrentUser.id, // ID do usuário atual
                                ReceitaID = receita.id,
                                saved = 1 // Marca como salva
                            };

                            ctx.ReceitaFavorira.Add(novaReceitaFavorita);
                        picboxFavoritar.Image = ByteArrayToImage(Resource1.favoritado);
                            MessageBox.Show("Receita salva como favorita!");
                        }

                        // Salva as alterações no banco de dados
                        ctx.SaveChanges();
                    }

                }
            }

        private void ReceitaUC_Click(object sender, EventArgs e)
        {
            DetalhesReceita detalhesReceita = new DetalhesReceita();
            detalhesReceita.CarregarDados(this.Receita);
            detalhesReceita.ShowDialog();
            
        }

        private void ReceitaUC_Load(object sender, EventArgs e)
        {
            pictureBox1.Click += ReceitaUC_Click;
            lblNome.Click += ReceitaUC_Click;
            lblTempo.Click += ReceitaUC_Click;
        }
    }
    }
