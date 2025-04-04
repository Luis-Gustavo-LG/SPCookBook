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
    public partial class Receitas : UserControl
    {
        public Receitas()
        {
            InitializeComponent();
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

                var receitas = ctx.ReceitaFavorira
            .Where(rf => rf.UsuarioID == UsuarioLogado.CurrentUser.id)
            .Select(rf => rf.UsuarioReceita) 
            .ToList();

                flowLayoutPanel1.Controls.Clear();

                foreach (var receita in receitas)
                {

                    string imagePath = Path.Combine(imageFolderPath, receita.id + ".jpg");

                    Image receitaImage = null;

                    if (File.Exists(imagePath))
                    {
                        receitaImage = Image.FromFile(imagePath);
                    }

                    ReceitaUC receitaUC = new ReceitaUC()
                    {
                        Receita = receita,
                        Nome = receita.NomeReceita,
                        Tempo = (int)receita.TempoMinutos,
                        Foto = receitaImage,
                        Favorito = ByteArrayToImage(Resource1.favoritado)
                    };

                    receitaUC.ReceitaDesfavoritada += (s, e) =>
                    {
                        flowLayoutPanel1.Controls.Remove(receitaUC);
                        UpdatedReceitas.Remove(receitaUC);
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

            foreach (var filtered in filteredReceitas)
            {
                flowLayoutPanel1.Controls.Add(filtered);
            }
        }
    }
}
