using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using ProducatorAvioane;
using Avion;
using Niveldestocare_Date;
using System.IO;
using System.Drawing.Printing;

namespace Targ_Avioane_Interfata
{
    public partial class Form1 : Form
    {
        private AdministrareAvioane_FisierText adminPlanes;
        //Constructurul  cu parametrii din clasa avion
        //private FormProductAvion AvionProduct;
        private const int AVION_NESELECTAT = -1;
        private BindingList<AvionClass> avioanele;
        private AvionClass avionActualizat;

        //vector

        /* private Label[ , ] lblsAvioane;
         private const int NUMAR_PROPRIETATI = 7;*/


        //txtIntroducereFirma

        //lblIntroducereModel
        //lblIntroducereAnfabricatie
        //lblIntroducereCuloare
        //lblIntroducereGreutate
        //lblIntrodcducerepret
        //lblIntroducerenrpasg


        //txtIntroducereAnFabricatie

        //txtIntroduceCuloare
        //txtIntroudceregreutate se gasesete in Form1.Designer.cs

        //numarul de pasageri
        //butoanele
        //btnAdaugaAvioane
        //label


        private const int LATIME_CONTROL = 90;
        private const int LUNGIME_CONTROL = 60;
        private const int DIMENSIUNEA_PAS_X = 100;
        private const int DIMENSIUNEA_PAS_Y = 120;
        private const int CARACTER_AN_FABRICATIE = 4;
        public Form1()
        {
            InitializeComponent();





            this.Size = new Size(1800, 1000);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Times New Roman", 8, FontStyle.Regular);
            this.ForeColor = Color.LimeGreen;
            this.Text = "BussinesPlaneUP";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
          
            

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminPlanes = new AdministrareAvioane_FisierText(caleCompletaFisier);
          
            
            //GotFocus-Control
            txtIntroducereFirma.GotFocus += txtIntroudcereFirmaGotFocus;
            txtIntroducereModel.GotFocus += txtIntroduceModelGotFocus;
            txtIntroducereAnFabricatie.GotFocus += txtIntroduceAnfabricatieGotFocus;
            txtIntroduceCuloare.GotFocus += txtIntroducereCuloareGotFocus;
            txtIntroduceregreutate.GotFocus += txtIntroduceGreutateGotFocus;
            txtIntroducepret.GotFocus += txtIntroduPretulGotFocus;
            txtIntroducerenrpasg.GotFocus += txtIntroducenrpasgGotFocus;

            //LostFocus
            txtIntroducereFirma.LostFocus += txtIntroducereFirmaLostFocus;
            txtIntroducereModel.LostFocus += txtIntroducereModelLostFocus;
            txtIntroducereAnFabricatie.LostFocus += txtIntroducereAnfabricatieLostFocus;
            txtIntroduceCuloare.LostFocus += txtIntroduceCuloareLostFocus;
            txtIntroduceregreutate.LostFocus += txtIntroduceGreutateLostFocus;
            txtIntroducepret.LostFocus += txtIntroducePretulLostFocus;
            txtIntroducerenrpasg.LostFocus += txtIntroducenrpasgLostFocus;

            this.FormClosed += OnFormClosed;
           
            ButoaneAvioane();

        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            List<AvionClass> avioane = adminPlanes.GetPlanes();
            AfiseazaDateGridAvion(avioane);
            avioanele = new BindingList<AvionClass>(adminPlanes.GetPlanes());
            dgvPlane.AutoGenerateColumns = true;
            dgvPlane.DataSource = avioane;
        }
       
      

        
        private void ButoaneAvioane()
        {
           
            btnAdaugaAvioane.Click += OnButtonClicked;
            btnRefresh.Click += OnButton2Clicked;

        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            bool valid = true;
        
            int an_fabricatie;
            Culoarea culoare;
            decimal greutate;
            decimal pret;
            int nr_pasageri;
             string firma=txtIntroducereFirma.Text.ToString();
             string model=txtIntroducereModel.Text.ToString();
            bool firmaValid=true;
            bool modelValid=true;
            bool an_FabricatieValid = Int32.TryParse(txtIntroducereAnFabricatie.Text.ToString(), out an_fabricatie);
            bool culoareValid = Enum.TryParse(txtIntroduceCuloare.Text.ToString(), out culoare);
            bool greutateValid = Decimal.TryParse(txtIntroduceregreutate.Text.ToString(), out greutate);
            bool pretValid=Decimal.TryParse(txtIntroducepret.Text.ToString(), out pret);
             bool nr_pasgariValid= Int32.TryParse(txtIntroducerenrpasg.Text.ToString(), out nr_pasageri);
            AvionClass avion = new AvionClass(0, firma,model,an_fabricatie,culoare,greutate,pret,nr_pasageri);

            TipAvion PlaneSelected = GetTipAvionSelectat();
            avion.AirplaneType = PlaneSelected;
            if (firmaValid && modelValid && an_FabricatieValid && culoareValid && greutateValid && pretValid && nr_pasgariValid)
                lblValidare.Text = "Toate date sunt valide";
            else
                lblValidare.Text = "Cel putin o variabila este valida";
            ///validare firma
            ///
            if (txtIntroducereFirma.Text.ToString() == "" )
            {
               
                lblIntroducereFirma.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtIntroducereFirma.Text.Length <2||txtIntroducereFirma.Text.Length > 20)
            {
                lblIntroducereFirma.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereFirma.ForeColor = Color.MediumBlue;
            if (txtIntroducereModel.Text.ToString() == "" )
            {
               
                lblIntroducereModel.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtIntroducereFirma.Text.Length > 20)
            {
                lblIntroducereModel.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereModel.ForeColor = Color.MediumBlue;

            //an fabricatie validare
            if (txtIntroducereAnFabricatie.Text.ToString() == "")
            {
                
                lblIntroducereAnfabricatie.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtIntroducereAnFabricatie.Text.Length > CARACTER_AN_FABRICATIE)
            {
                lblIntroducereAnfabricatie.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereAnfabricatie.ForeColor = Color.MediumBlue;

            if (txtIntroduceCuloare.Text.ToString() == "")
            {
           
                lblIntroducereCuloare.ForeColor = Color.Red;
                valid = false;

            }
            else if (txtIntroduceCuloare.Text.Length > 30)
            {

                lblIntroducereCuloare.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereCuloare.ForeColor = Color.MediumBlue;

            if (txtIntroduceregreutate.Text.ToString() == "")
            {
                
                lblIntroducereGreutate.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereGreutate.ForeColor = Color.MediumBlue;

            if (txtIntroducepret.Text.ToString() == "")
            {
                
                lblIntrodcducerepret.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntrodcducerepret.ForeColor = Color.MediumBlue;

            if (txtIntroducerenrpasg.Text.ToString() == "")
            {
                lblIntroducerenrpasg.ForeColor = Color.Red;
                valid = false;
            }
            else if (nr_pasageri < 0)
            {
                lblIntroducerenrpasg.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducerenrpasg.ForeColor = Color.MediumBlue;


            ///verificariile
            if (valid)
            {
                adminPlanes.AddPlane(avion);
                ResetControls();
                lblSalvarePlane.Text = "Avion adaugat";
            }
            else
            {
                lblSalvarePlane.Text = "Informatiile sunt introduse incorect";
                
            }
            
        }
         private void ResetControls()
        {
            txtIntroducereFirma.Text = txtIntroducereModel.Text = txtIntroducereAnFabricatie.Text = txtIntroduceCuloare.Text = string.Empty;
            txtIntroduceregreutate.Text = txtIntroducepret.Text = txtIntroducerenrpasg.Text = string.Empty;
            lblIntroducereFirma.ForeColor = Color.MediumBlue;
            lblIntroducereModel.ForeColor = Color.MediumBlue;
            lblIntroducereAnfabricatie.ForeColor = Color.MediumBlue;
            lblIntroducereCuloare.ForeColor = Color.MediumBlue;
            lblIntroducereGreutate.ForeColor = Color.MediumBlue;
            lblIntrodcducerepret.ForeColor = Color.MediumBlue;
            lblIntroducerenrpasg.ForeColor = Color.MediumBlue;
            rdbCivil.Checked = false;
            rdbComercial.Checked = false;
            rdbExperimental.Checked = false;
            rdbMilitar.Checked = false;

            lblSalvarePlane.Text = "";
          

        }
        
        private void OnButton2Clicked(object sender,EventArgs e)  //Butonul Refresh este butonul de actualizare
        {
            List<AvionClass> avioane = adminPlanes.GetPlanes();

            AfiseazaDateGridAvion(avioane);
            lblRefreshDate.Text = "Datele despre avioane au fost actualizate";
            ResetControls();
            lblValidare.Text = "";

           
            dgvPlane.DataSource = null;
            dgvPlane.DataSource = avioanele;
             dgvPlane.Refresh();
          // adminPlanes.UpdateAvion(avionActualizat);

        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            
                Application.Exit();
            
        }
        //Firma GotFocus si LostFocus
        private void txtIntroudcereFirmaGotFocus(object sender, EventArgs e)
        {
            txtIntroducereFirma.BackColor = Color.Chocolate;
        }
        //Model GotFocus si LostFocus
        private void txtIntroducereFirmaLostFocus(object sender,EventArgs e)
        {
            txtIntroducereFirma.BackColor = SystemColors.Window;
        }
       private void txtIntroduceModelGotFocus(object sender,EventArgs e)
        {
            txtIntroducereModel.BackColor = Color.Chocolate;
        }
        
        private void txtIntroducereModelLostFocus(object sender,EventArgs e)
        {
            txtIntroducereModel.BackColor = SystemColors.Window;
        }
        //txtAnfabricatie GotFocus si LostFocus
        private void txtIntroduceAnfabricatieGotFocus(object sender, EventArgs e)
        {
            txtIntroducereAnFabricatie.BackColor = Color.Chocolate;
            
        }
        private void txtIntroducereAnfabricatieLostFocus(object sender, EventArgs e)
        {
            txtIntroducereAnFabricatie.BackColor = SystemColors.Window;
        }
        //txtCuloare pentru GotFocus si LostFocus
        private void txtIntroducereCuloareGotFocus(object sender,EventArgs e)
        {
            txtIntroduceCuloare.BackColor = Color.Chocolate;

        }
        private void txtIntroduceCuloareLostFocus(object sender,EventArgs e)
        {
            txtIntroduceCuloare.BackColor = SystemColors.Window;
        }
        //txtIntroducegreutate pentru GotFocus si LostFocus
        private void txtIntroduceGreutateGotFocus(object sender,EventArgs e)
        {
            txtIntroduceregreutate.BackColor = Color.Chocolate;
        }
        private void txtIntroduceGreutateLostFocus(object sender,EventArgs e)
        {
            txtIntroduceregreutate.BackColor = SystemColors.Window;
        }
        //txtIntroducepret pentru GotFocus si LostFocus -caseta text
        private void txtIntroduPretulGotFocus(object sender,EventArgs e)
        {
            txtIntroducepret.BackColor = Color.Chocolate;
        }
        private void txtIntroducePretulLostFocus(object sender,EventArgs e)
        {
            txtIntroducepret.BackColor = SystemColors.Window;

        }
        //txtNrpasageri-pentru GotFocus si LostFocus- caseta text
        private void  txtIntroducenrpasgGotFocus(object sender,EventArgs e)
        {
            txtIntroducerenrpasg.BackColor = Color.Chocolate;

        }
        private void txtIntroducenrpasgLostFocus(object sender,EventArgs e)
        {
            txtIntroducerenrpasg.BackColor = SystemColors.Window;
        }
            //  la intoarcere meniul principal,cand utilizatorul paraseste fereatra Avioane(contin datele din AvionClass)
        private void btnBackMainMenu_2_Click(object sender, EventArgs e)
        {
            MainMenuPlane frame_cy= new MainMenuPlane();
            frame_cy.Show();
            this.Hide();
        }
          private TipAvion GetTipAvionSelectat()
          {  
            if(rdbCivil.Checked)
                return TipAvion.Civil;
            if (rdbComercial.Checked)
                return TipAvion.Comercial;
            if (rdbExperimental.Checked)
                return TipAvion.Experimental;
            if (rdbMilitar.Checked)
                return TipAvion.Militar;
            return TipAvion.Nedefinit;

          } 
        private void rdbComercial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
              AvionClass axa = adminPlanes.GetPlane(txtIntroducereFirma.Text, txtIntroducereModel.Text,Int32.Parse(txtIntroducereAnFabricatie.Text),(Culoarea)Enum.Parse(typeof(Culoarea),txtIntroduceCuloare.Text));
            if (axa == null)
               lblSalvarePlane.Text = "Avionul nu a fost gasit!";

            else
               lblSalvarePlane.Text = "Avionul a fost gasit";

        }

       private void AfiseazaDateGridAvion(List<AvionClass> avioane)
        {
            dgvPlane.DataSource = null;
            //
            //!!!! Controlul de tip DataGridView are ca sursa de date lista de obiecte de tip AvionClass !!!
            dgvPlane.DataSource = avioane;

            dgvPlane.DataSource = avioane.Select(s => new {
                s.ID_avion,
                s.firma,
                s.model,
                s.an_fabricatie,
                s.culoare,
                s.greutate,
                s.pret,
                s.nr_de_pasageri,
                s.AirplaneType,
                //s.Componente

                
                
            }).ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIntroducereFirma.Text = txtIntroducereModel.Text = txtIntroducereAnFabricatie.Text = txtIntroduceCuloare.Text = string.Empty;
            txtIntroduceregreutate.Text = txtIntroducepret.Text = txtIntroducerenrpasg.Text = string.Empty;
            lblIntroducereFirma.ForeColor = Color.MediumBlue;
            lblIntroducereModel.ForeColor = Color.MediumBlue;
            lblIntroducereAnfabricatie.ForeColor = Color.MediumBlue;
            lblIntroducereCuloare.ForeColor = Color.MediumBlue;
            lblIntroducereGreutate.ForeColor = Color.MediumBlue;
            lblIntrodcducerepret.ForeColor = Color.MediumBlue;
            lblIntroducerenrpasg.ForeColor = Color.MediumBlue;
            rdbCivil.Checked = false;
            rdbComercial.Checked = false;
            rdbExperimental.Checked = false;
            rdbMilitar.Checked = false;

            lblSalvarePlane.Text = "";
            lblValidare.Text = "";
            lblRefreshDate.Text = "";

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
           
            if (dgvPlane.SelectedRows.Count == AVION_NESELECTAT)
            {
                MessageBox.Show("Selectare");
            }
            else
            {
                dgvPlane.DataSource = avioanele;
                for (int i = dgvPlane.SelectedRows.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = dgvPlane.SelectedRows[i].Index;

                    // Șterge elementul din BindingList
                    avioanele.RemoveAt(selectedIndex);
                   
                }
                dgvPlane.DataSource = null;
                dgvPlane.DataSource = avioanele;
            }
                //avioane.RemoveAt(dgvPlane.SelectedRows.Count);
        }

     
    }
}
