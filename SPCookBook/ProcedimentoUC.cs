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
    public partial class ProcedimentoUC : UserControl
    {
        public ProcedimentoUC()
        {
            InitializeComponent();
        }

        private void ProcedimentoUC_Load(object sender, EventArgs e)
        {

        }

        public string StepNumero
        {
            get => lbl_stepNumero.Text;
            set => lbl_stepNumero.Text = $"Step {value}";
        }

        public string StepTexto
        {
            get => lbl_stepTexto.Text;
            set => lbl_stepTexto.Text = value;
        }
    }
}
