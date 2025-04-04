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
    public partial class DetalhesReceita : Form
    {

        public DetalhesReceita()
        {
            InitializeComponent();
        }

        public void CarregarDados(UsuarioReceita usuarioReceita)
        {
            string appFolderPath = Application.StartupPath;

            string imageFolderPath = Path.Combine(appFolderPath, "users recipe images");

            string imagePath = Path.Combine(imageFolderPath, usuarioReceita.id + ".jpg");

            picbox_receita.Image = Image.FromFile(imagePath);

            lbl_nome.Text = usuarioReceita.NomeReceita;

            lbl_tempo.Text = $"{usuarioReceita.TempoMinutos} Min";

            using(SPCookbookEntities ctx  = new SPCookbookEntities())
            {
                var saves = ctx.ReceitaFavorira.Where(rf => rf.ReceitaID == usuarioReceita.id).Count();

                lbl_salvos.Text = $"{saves} Salvos";

                flp_ingredientes.Controls.Clear();
                flp_procedimentos.Controls.Clear();

                var ingredientes = ctx.IngredientesReceita.Where(i => i.ReceitaID == usuarioReceita.id).ToList();

                foreach(var i in ingredientes)
                {
                    IngredienteDetalhesUC IngredienteUC = new IngredienteDetalhesUC()
                    {
                        Nome = i.Ingrediente.nome,
                        Gramas = (int)i.qtdGramas
                    };

                    flp_ingredientes.Controls.Add(IngredienteUC);
                }


                var procedimentos = ctx.ProcedimentoReceitas.Where(i => i.userRecipeID == usuarioReceita.id).ToList();

                foreach( var p in procedimentos)
                {
                    ProcedimentoUC procedimentoUC = new ProcedimentoUC()
                    {
                        StepNumero = p.stepSequence.ToString(),
                        StepTexto = p.step
                    };

                    flp_procedimentos.Controls.Add(procedimentoUC);
                }
            }          
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
