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
            

            txtCompanie.GotFocus += txtCompanieGotFocus;
            txtTaraOrigine.GotFocus += txtTaraOrigineGotFocus;
            txtAnInfiintare.GotFocus += txtAnInfiintareGotFocus;
            txtNrAngajati.GotFocus += txtNrAngajatiGotFocus;
            txtSpecializare.GotFocus += txtSpecGotFocus;

            //Lost focus

            txtCompanie.LostFocus += txtCompanieLostFocus;
            txtTaraOrigine.LostFocus += txtTaraOrigineLostFocus;
            txtAnInfiintare.LostFocus += txtAnInfiintareLostFocus;
            txtNrAngajati.LostFocus += txtNrAngajatiLostFocus;
            txtSpecializare.LostFocus += txtSpecLostFocus;

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
        private void txtCompanieGotFocus(object sender,EventArgs e)
        {
            txtCompanie.BackColor = Color.Aquamarine;


        }
        private void txtTaraOrigineGotFocus(object sender,EventArgs e)
        {
            txtTaraOrigine.BackColor = Color.Aquamarine;
        }
        private void txtAnInfiintareGotFocus(object sender,EventArgs e)
        {
            txtAnInfiintare.BackColor = Color.Aquamarine;
        }

        private void txtNrAngajatiGotFocus(object sender,EventArgs e)
        {
            txtNrAngajati.BackColor = Color.Aquamarine;
        }
        private void txtSpecGotFocus(object sender,EventArgs e)
        {
            txtSpecializare.BackColor = Color.Aquamarine;
        }
        private void txtCompanieLostFocus(object sender, EventArgs e)
        {
            txtCompanie.BackColor = SystemColors.Window;


        }
        private void txtTaraOrigineLostFocus(object sender, EventArgs e)
        {
            txtTaraOrigine.BackColor = SystemColors.Window;
        }
        private void txtAnInfiintareLostFocus(object sender, EventArgs e)
        {
            txtAnInfiintare.BackColor = SystemColors.Window;
        }

        private void txtNrAngajatiLostFocus(object sender, EventArgs e)
        {
            txtNrAngajati.BackColor = SystemColors.Window;
        }
        private void txtSpecLostFocus(object sender,EventArgs e)
        {
            txtSpecializare.BackColor = SystemColors.Window;
        }
        private void btnAdaugaProductPlane_Click(object sender, EventArgs e)
        {
            int AnInfiintare;
            int nrAngajati;
            Specializarea spec;
            txtCompanie.Text.ToString();
            txtTaraOrigine.ToString();
            Int32.TryParse(txtAnInfiintare.Text.ToString(), out AnInfiintare);
            Int32.TryParse(txtNrAngajati.Text.ToString(), out nrAngajati);
            Enum.TryParse(txtSpecializare.Text.ToString(),out spec);

            ProductAvion producator = new ProductAvion(0, txtCompanie.Text.ToString(), txtTaraOrigine.Text.ToString(),AnInfiintare,nrAngajati,spec);
            administratorProducatorPlane.AddProducator(producator);

        }

        private void btnRefreshProductPlane_Click(object sender, EventArgs e)
        {
            Afiseaza_Producatori_Aeronave();

        }
    }
}
