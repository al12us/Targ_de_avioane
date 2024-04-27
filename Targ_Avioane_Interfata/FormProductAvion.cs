using Avion;
using Niveldestocare_Date;
using ProducatorAvioane;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targ_Avioane_Interfata
{
    public partial class FormProductAvion : Form
    {
        private AdministratorProducator_FisierText administratorProducatorPlane;
        public FormProductAvion()
        {
            InitializeComponent();
            string numeFisier_2 = ConfigurationManager.AppSettings["NumeFisier_2"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier_2;
            administratorProducatorPlane = new AdministratorProducator_FisierText(caleCompletaFisier);

            this.Load += FormProductAvionLoad;

        }

        private void Afiseaza_Producatori_Aeronave()
        {
            List<ProductAvion> producatori = administratorProducatorPlane.GetProducts();
            int nr_producatori = producatori.Count;
            lstProductPlane.Items.Clear();
            foreach (var producator in producatori)
            {
                lstProductPlane.Items.Add(producator.InfoProduct);
            }
        }
        private void FormProductAvionLoad(object sender, EventArgs e)
        {
            Afiseaza_Producatori_Aeronave();
        }
      

 
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuPlane frame = new MainMenuPlane();
            frame.Show();
            this.Hide();


        }
    }
}
