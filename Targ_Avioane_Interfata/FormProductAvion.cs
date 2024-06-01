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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targ_Avioane_Interfata
{
    public partial class FormProductAvion : Form
    {
        private AdministratorProducator_FisierText administratorProducatorPlane;
        private const string MESAJ= "Obligatoriu!";
        private const int STRLEN_MIN_COMPANIE = 5;
        private const int STRLEN_MAX_COMPANIE = 30;
        private const int STRLEN_MAX_TARA_ORIGINE = 60;
        private const int PRODUCATOR_AVION_NESELECTAT = -1;
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
           
            //Lost focus

            txtCompanie.LostFocus += txtCompanieLostFocus;
            txtTaraOrigine.LostFocus += txtTaraOrigineLostFocus;
            txtAnInfiintare.LostFocus += txtAnInfiintareLostFocus;
            txtNrAngajati.LostFocus += txtNrAngajatiLostFocus;
         
        }

        private void Afiseaza_Producatori_Aeronave()
        {
            List<ProductAvion> producatori = administratorProducatorPlane.GetProducts();
            int nr_producatori = producatori.Count;
            lstProductPlane.Items.Clear();
            foreach (var producator in producatori)
            {
                
                lstProductPlane.Items.Add(producator.ToString());
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
        
        private void btnAdaugaProductPlane_Click(object sender, EventArgs e)
        {
            int AnInfiintare;
            int nrAngajati;
           
           string companie= txtCompanie.Text.ToString();
            string taradeorigine=txtTaraOrigine.ToString();
            Int32.TryParse(txtAnInfiintare.Text.ToString(), out AnInfiintare);
            Int32.TryParse(txtNrAngajati.Text.ToString(), out nrAngajati);
            var specializari = new List<Specializarea>();
            ProductAvion producator = new ProductAvion(0, txtCompanie.Text.ToString(), txtTaraOrigine.Text.ToString(),AnInfiintare,nrAngajati,specializari);
         
            bool validProductPlane = true;
            if (txtCompanie.Text.ToString() == "" || txtCompanie.Text.ToString() == MESAJ)
            {
                
                lblCompanie.ForeColor = Color.Red;
                validProductPlane = false;
            }
            else if (txtCompanie.Text.Length < STRLEN_MIN_COMPANIE || txtCompanie.TextLength > STRLEN_MAX_COMPANIE)
            {
                txtCompanie.ForeColor = Color.Red;
                validProductPlane = false;
            }
            else
                txtCompanie.ForeColor = Color.SaddleBrown;
            if (txtTaraOrigine.Text.ToString() == "" )
            {
                lblTaraOrigine.ForeColor = Color.Red;
                validProductPlane = false;
            }
            else if (txtTaraOrigine.Text.Length < STRLEN_MIN_COMPANIE || txtTaraOrigine.TextLength > STRLEN_MAX_TARA_ORIGINE)
            {
                lblTaraOrigine.ForeColor = Color.Red;
                validProductPlane = false;
            }
            else
                txtTaraOrigine.ForeColor = Color.SaddleBrown;
            if (txtAnInfiintare.Text.ToString() == "" || txtAnInfiintare.Text.ToString() == MESAJ)
            {
                
                lblAnInfiintare.ForeColor = Color.Red;
                validProductPlane = false;
            }
            else
                lblAnInfiintare.ForeColor = Color.SaddleBrown;
            if (txtNrAngajati.Text.ToString() == "" || txtNrAngajati.Text.ToString() == MESAJ)
            {
               
                lblnrAngajati.ForeColor = Color.Red;
                validProductPlane = false;
            }
            else
                lblnrAngajati.ForeColor = Color.SaddleBrown;
          

            if (validProductPlane)
            {
                administratorProducatorPlane.AddProducator(producator);
                lblSalvareProductPlane.Text = "Producatorul de avioane a fost adaugat";
                ResetControls();
            }
            else
            {
                lblSalvareProductPlane.Text = "Informatiile sunt introduse incorect";
                ResetControls();
            }


        }
        private void ResetControls()
        {
            txtCompanie.Text = txtTaraOrigine.Text = txtAnInfiintare.Text = txtNrAngajati.Text = string.Empty;
            
 
        }
        private void btnRefreshProductPlane_Click(object sender, EventArgs e)
        {
            Afiseaza_Producatori_Aeronave();
            lblRefreshProductPlane.Text = "Lista de producatori de avioane reincarcati ";

        }

        private void btnStergeProductPlane_Click(object sender, EventArgs e)
        {
            if (lstProductPlane.SelectedIndex == PRODUCATOR_AVION_NESELECTAT)
            {
                MessageBox.Show("Selectati producatorul pentru stergere");
            }
            else
            {
                int index = lstProductPlane.SelectedIndex;
                List<ProductAvion> producatori = administratorProducatorPlane.GetProducts();
                //se sterge un element din lista
                if (index >= 0 && index < producatori.Count)
                {
                    ProductAvion producatorDeSters = producatori[index];
                    administratorProducatorPlane.StergeProducatorul(producatorDeSters);
                    Afiseaza_Producatori_Aeronave();
                }
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            ProductAvion productAvion = administratorProducatorPlane.GetProductPlane(txtCompanie.Text, txtTaraOrigine.Text);
            if (productAvion == null)
                lblSalvareProductPlane.Text = "Producatorul de avioane nu a fost gasit";
            else
                lblSalvareProductPlane.Text = "Producatorul de avioane a fost gasit";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompanie.Text = txtTaraOrigine.Text = txtAnInfiintare.Text = txtNrAngajati.Text = string.Empty;
            lblSalvareProductPlane.Text = "";
            lblRefreshProductPlane.Text = "";
        }

        private void ckbSpecializare_CheckedChanged(object sender, EventArgs e)
        {
            List<Specializarea> specializariSelectate = new List<Specializarea>();

            CheckBox checkBoxControl = sender as CheckBox;
            var specializare = (Specializarea)Enum.Parse(typeof(Specializarea), checkBoxControl.Text);
            if (checkBoxControl.Checked==true)
                 specializariSelectate.Add(specializare); 
            else
                specializariSelectate.Remove(specializare);
        }
    }
    }


