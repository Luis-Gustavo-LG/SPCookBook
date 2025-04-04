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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            btn_limparBusca.Enabled = false;
            CarregarDados();
        }

        List<ReceitaUC> UpdatedReceitas = new List<ReceitaUC>();

        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void CarregarDados()
        {


            using (var ctx = new SPCookbookEntities())
            {
                string appFolderPath = Application.StartupPath;

                string imageFolderPath = Path.Combine(appFolderPath, "users recipe images");

                var receitas = ctx.UsuarioReceita.ToList();

                flowLayoutPanel1.Controls.Clear();

                foreach (var receita in receitas)
                {

                    string imagePath = Path.Combine(imageFolderPath, receita.id + ".jpg");

                    Image receitaImage = null;

                    if (File.Exists(imagePath))
                    {
                        receitaImage = Image.FromFile(imagePath);
                    }

                    bool isFavorited = ctx.ReceitaFavorira
                          .Any(rf => rf.ReceitaID == receita.id && rf.UsuarioID == UsuarioLogado.CurrentUser.id);

                    ReceitaUC receitaUC = new ReceitaUC()
                    {
                        Receita = receita,
                        Nome = receita.NomeReceita,
                        Tempo = (int)receita.TempoMinutos,
                        Foto = receitaImage,
                        Favorito = isFavorited ? ByteArrayToImage(Resource1.favoritado) : ByteArrayToImage(Resource1.naofavoritado),
                        IsFavorito = isFavorited
                    };

                    flowLayoutPanel1.Controls.Add(receitaUC);
                    UpdatedReceitas.Add(receitaUC);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string busca = textBox1.Text.ToLower();

            flowLayoutPanel1.Controls.Clear();

            var filteredReceitas = UpdatedReceitas.Where(r => r.Nome.ToLower().Contains(busca)).ToList();

            foreach ( var filtered in filteredReceitas )
            {
                flowLayoutPanel1.Controls.Add(filtered);
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            var noFavoriteReceita = UpdatedReceitas.Where(r => !r.IsFavorito).ToList();

            if(noFavoriteReceita.Count > 0)
            {
                Random random = new Random();

                int randomIndex = random.Next(noFavoriteReceita.Count);

                ReceitaUC randomReceita = noFavoriteReceita[randomIndex];

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(randomReceita);

                btn_limparBusca.Enabled = true;
            }
        }

        private void btn_limparBusca_Click(object sender, EventArgs e)
        {
            CarregarDados();
            btn_limparBusca.Enabled = false;
        }
    }
}
