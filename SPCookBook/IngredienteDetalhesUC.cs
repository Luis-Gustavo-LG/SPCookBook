using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCookBook
{
    public partial class IngredienteDetalhesUC : UserControl
    {
        public IngredienteDetalhesUC()
        {
            InitializeComponent();
        }

        public string Nome
        {
            get => lbl_ingrediente.Text;
            set => lbl_ingrediente.Text = value;
        }

        public int Gramas
        {
            get => int.TryParse(lbl_gramas.Text.Replace(" g", ""), out int value) ? value : 0;
            set => lbl_gramas.Text = $"{value}g";
        }
    }
}
