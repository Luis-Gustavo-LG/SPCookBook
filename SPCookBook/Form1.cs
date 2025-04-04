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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPage(new Home());
            HighlightButton(button1);
        }

        private Button activeButton;

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void HighlightButton(Button selectedButton)
        {
            
            if (activeButton != null)
            {
                activeButton.BackColor = SystemColors.ControlLightLight;
                activeButton.ForeColor = SystemColors.ControlText;
                activeButton.FlatAppearance.BorderSize = 0;
            }
           
            activeButton = selectedButton;
            activeButton.FlatAppearance.BorderSize = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new Home());
            HighlightButton(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPage(new Receitas());
            HighlightButton(button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
