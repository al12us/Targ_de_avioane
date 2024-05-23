using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targ_Avioane_Interfata
{
    public partial class MainMenuPlane : Form
    {
        public MainMenuPlane()
        {
            InitializeComponent();
            this.FormClosed +=OnFormClosedMainMenu ;
        }

        private void OnFormClosedMainMenu(object sender, EventArgs e)
        {

            Application.Exit();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormAvion = new Form1();
            FormAvion.FormClosed += (s, args) => this.Close();
            FormAvion.Show();

        }

        private void btnProducatorAvioane_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormAvion = new FormProductAvion();
            FormAvion.FormClosed += (s, args) => this.Close();
            FormAvion.Show();
        }
    }
}
