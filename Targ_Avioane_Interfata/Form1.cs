using Avion;
using Niveldestocare_Date;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Targ_Avioane_Interfata
{
    public partial class Form1 : Form
    {
        private AdministrareAvioane_FisierText adminPlanes;
        //Constructurul  cu parametrii din clasa avion
      
        private const int AVION_NESELECTAT = -1;
        private BindingList<AvionClass> avioanele;



      ArrayList ComponenteSelectate = new ArrayList();

        private const int CARACTER_MAX = 20;
        private const int CARACTER_MIN = 2;
        private const int CARACTER_AN_FABRICATIE = 4;
        private const int CARACTER_MAX_CULOARE = 30;
        private const int NR_NEGATIV= 0;
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
            dgvPlane.ForeColor = Color.MediumBlue;
            
            //GotFocus-Control
            txtFirma.GotFocus += txtIntroudcereFirmaGotFocus;
            txtModel.GotFocus += txtIntroduceModelGotFocus;
            txtAnFabricatie.GotFocus += txtIntroduceAnfabricatieGotFocus;
            txtCuloare.GotFocus += txtIntroducereCuloareGotFocus;
            txtGreutate.GotFocus += txtIntroduceGreutateGotFocus;
            txtPret.GotFocus += txtIntroduPretulGotFocus;
            txtNrPasg.GotFocus += txtIntroducenrpasgGotFocus;

            //LostFocus
            txtFirma.LostFocus += txtIntroducereFirmaLostFocus;
            txtModel.LostFocus += txtIntroducereModelLostFocus;
            txtAnFabricatie.LostFocus += txtIntroducereAnfabricatieLostFocus;
            txtCuloare.LostFocus += txtIntroduceCuloareLostFocus;
            txtGreutate.LostFocus += txtIntroduceGreutateLostFocus;
            txtPret.LostFocus += txtIntroducePretulLostFocus;
            txtNrPasg.LostFocus += txtIntroducenrpasgLostFocus;

            this.FormClosed += OnFormClosed;
          
            ButoaneAvioane();

        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            List<AvionClass> avioane = adminPlanes.GetPlanes();
            AfiseazaDateGridAvion(avioane);
          

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
             string firma=txtFirma.Text.ToString();
             string model=txtModel.Text.ToString();
            bool firmaValid=true;
            bool modelValid=true;
            bool an_FabricatieValid = Int32.TryParse(txtAnFabricatie.Text.ToString(), out an_fabricatie);
            bool culoareValid = Enum.TryParse(txtCuloare.Text.ToString(), out culoare);
            bool greutateValid = Decimal.TryParse(txtGreutate.Text.ToString(), out greutate);
            bool pretValid=Decimal.TryParse(txtPret.Text.ToString(), out pret);
             bool nr_pasgariValid= Int32.TryParse(txtNrPasg.Text.ToString(), out nr_pasageri);
            AvionClass avion = new AvionClass(0, firma,model,an_fabricatie,culoare,greutate,pret,nr_pasageri);

            TipAvion PlaneSelected = GetTipAvionSelectat();
            avion.AirplaneType = PlaneSelected;
            //set componente Avion
            avion.Componente = new ArrayList();
            avion.Componente.AddRange(ComponenteSelectate);

            if (firmaValid && modelValid && an_FabricatieValid && culoareValid && greutateValid && pretValid && nr_pasgariValid)
                lblValidare.Text = "Toate date sunt valide";
            else
                lblValidare.Text = "Cel putin o variabila este valida";
            ///validare firma
            ///
            if (txtFirma.Text.ToString() == "" )
            {
               
                lblIntroducereFirma.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtFirma.Text.Length <CARACTER_MIN||txtFirma.Text.Length > CARACTER_MAX)
            {
                lblIntroducereFirma.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereFirma.ForeColor = Color.MediumBlue;
            if (txtModel.Text.ToString() == "" )
            {
               
                lblIntroducereModel.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtFirma.Text.Length > CARACTER_MAX)
            {
                lblIntroducereModel.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereModel.ForeColor = Color.MediumBlue;

            //an fabricatie validare
            if (txtAnFabricatie.Text.ToString() == "")
            {
                
                lblIntroducereAnfabricatie.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtAnFabricatie.Text.Length > CARACTER_AN_FABRICATIE)
            {
                lblIntroducereAnfabricatie.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereAnfabricatie.ForeColor = Color.MediumBlue;

            if (txtCuloare.Text.ToString() == "")
            {
           
                lblIntroducereCuloare.ForeColor = Color.Red;
                valid = false;

            }
            else if (txtCuloare.Text.Length > CARACTER_MAX_CULOARE)
            {

                lblIntroducereCuloare.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereCuloare.ForeColor = Color.MediumBlue;

            if (txtGreutate.Text.ToString() == "")
            {
                
                lblIntroducereGreutate.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntroducereGreutate.ForeColor = Color.MediumBlue;

            if (txtPret.Text.ToString() == "")
            {
                
                lblIntrodcducerepret.ForeColor = Color.Red;
                valid = false;
            }
            else
                lblIntrodcducerepret.ForeColor = Color.MediumBlue;

            if (txtNrPasg.Text.ToString() == "")
            {
                lblIntroducerenrpasg.ForeColor = Color.Red;
                valid = false;
            }
            else if (nr_pasageri < NR_NEGATIV)
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
            txtFirma.Text = txtModel.Text = txtAnFabricatie.Text = txtCuloare.Text = string.Empty;
            txtGreutate.Text = txtPret.Text = txtNrPasg.Text = string.Empty;
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

            ckbAdaptare.Checked = false;
            ckbAprovizionare.Checked = false;
            ckbAeroframe.Checked = false;
            ckbComunicare.Checked = false;
            ckbControlAutomatizare.Checked = false;
            ckbSistemedeArmament.Checked = false;
            ckbSistemDeContramasuri.Checked = false;
            ckbSigurantaSupraveghere.Checked = false;
            ckbNavigare.Checked = false;
            ckbPropulsie.Checked = false;


            lblSalvarePlane.Text = "";
          

        }
        
        private void OnButton2Clicked(object sender,EventArgs e)  //Butonul Refresh este butonul de actualizare
        {
            List<AvionClass> avioane = adminPlanes.GetPlanes();

            AfiseazaDateGridAvion(avioane);
            lblRefreshDate.Text = "Datele despre avioane au fost actualizate";
            ResetControls();
            lblValidare.Text = "";
            //dgvPlane.Refresh();
           
           
             
           

        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            
                Application.Exit();
            
        }
        //Firma GotFocus si LostFocus
        private void txtIntroudcereFirmaGotFocus(object sender, EventArgs e)
        {
            txtFirma.BackColor = Color.Chocolate;
        }
        //Model GotFocus si LostFocus
        private void txtIntroducereFirmaLostFocus(object sender,EventArgs e)
        {
            txtFirma.BackColor = SystemColors.Window;
        }
       private void txtIntroduceModelGotFocus(object sender,EventArgs e)
        {
            txtModel.BackColor = Color.Chocolate;
        }
        
        private void txtIntroducereModelLostFocus(object sender,EventArgs e)
        {
            txtModel.BackColor = SystemColors.Window;
        }
        //txtAnfabricatie GotFocus si LostFocus
        private void txtIntroduceAnfabricatieGotFocus(object sender, EventArgs e)
        {
            txtAnFabricatie.BackColor = Color.Chocolate;
            
        }
        private void txtIntroducereAnfabricatieLostFocus(object sender, EventArgs e)
        {
            txtAnFabricatie.BackColor = SystemColors.Window;
        }
        //txtCuloare pentru GotFocus si LostFocus
        private void txtIntroducereCuloareGotFocus(object sender,EventArgs e)
        {
            txtCuloare.BackColor = Color.Chocolate;

        }
        private void txtIntroduceCuloareLostFocus(object sender,EventArgs e)
        {
            txtCuloare.BackColor = SystemColors.Window;
        }
        //txtIntroducegreutate pentru GotFocus si LostFocus
        private void txtIntroduceGreutateGotFocus(object sender,EventArgs e)
        {
            txtGreutate.BackColor = Color.Chocolate;
        }
        private void txtIntroduceGreutateLostFocus(object sender,EventArgs e)
        {
            txtGreutate.BackColor = SystemColors.Window;
        }
        //txtIntroducepret pentru GotFocus si LostFocus -caseta text
        private void txtIntroduPretulGotFocus(object sender,EventArgs e)
        {
            txtPret.BackColor = Color.Chocolate;
        }
        private void txtIntroducePretulLostFocus(object sender,EventArgs e)
        {
            txtPret.BackColor = SystemColors.Window;

        }
        //txtNrpasageri-pentru GotFocus si LostFocus- caseta text
        private void  txtIntroducenrpasgGotFocus(object sender,EventArgs e)
        {
            txtNrPasg.BackColor = Color.Chocolate;

        }
        private void txtIntroducenrpasgLostFocus(object sender,EventArgs e)
        {
            txtNrPasg.BackColor = SystemColors.Window;
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
              AvionClass axa = adminPlanes.GetPlane(txtFirma.Text, txtModel.Text,Int32.Parse(txtAnFabricatie.Text),(Culoarea)Enum.Parse(typeof(Culoarea),txtCuloare.Text));
            if (axa == null)
               lblSalvarePlane.Text = "Avionul nu a fost gasit!";

            else
               lblSalvarePlane.Text = "Avionul a fost gasit";

        }

       private void AfiseazaDateGridAvion(List<AvionClass> avioane)
        {

            //!!!! Controlul de tip DataGridView are ca sursa de date lista de obiecte de tip AvionClass !!!
            dgvPlane.DataSource = null;
            dgvPlane.ClearSelection(); ;
            var lista = avioane.Select(s => new {
                s.ID_avion,
                s.firma,
                s.model,
                s.an_fabricatie,
                s.culoare,
                s.greutate,
                s.pret,
                s.nr_de_pasageri,
                s.AirplaneType,
                Comps = string.Join(" ",s.Componente.ToArray())
            }).ToList();
            dgvPlane.DataSource = lista;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirma.Text = txtModel.Text = txtAnFabricatie.Text = txtCuloare.Text = string.Empty;
            txtGreutate.Text = txtPret.Text = txtNrPasg.Text = string.Empty;
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

            ckbAdaptare.Checked = false;
            ckbAprovizionare.Checked = false;
            ckbAeroframe.Checked = false;
            ckbComunicare.Checked = false; 
            ckbControlAutomatizare.Checked = false;
            ckbSistemedeArmament.Checked = false;
            ckbSistemDeContramasuri.Checked = false;
            ckbSigurantaSupraveghere.Checked = false;
            ckbNavigare.Checked = false;
            ckbPropulsie.Checked = false;


            lblSalvarePlane.Text = "";
            lblValidare.Text = "";
            lblRefreshDate.Text = "";

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            dgvPlane.DataSource = avioanele;
            if (dgvPlane.SelectedRows.Count > 0)
            {
                AvionClass avionul_modificat = (AvionClass)dgvPlane.SelectedRows[0].DataBoundItem;
                // Se va prelua indexul elementului selectat din DataGridView
                int selectedIndex = dgvPlane.SelectedRows[0].Index;
                // Se va prelua avionul corespunzător indexului selectat
                AvionClass avion_modificat = avioanele[selectedIndex];
                if (avion_modificat != null )
                {
                    // Casetele txt
                    avion_modificat.firma = txtFirma.Text;
                    avion_modificat.model = txtModel.Text;
                    avion_modificat.an_fabricatie = Int32.Parse(txtAnFabricatie.Text);
                    avion_modificat.culoare = (Culoarea)Enum.Parse(typeof(Culoarea), txtCuloare.Text);
                    avion_modificat.greutate = Int32.Parse(txtGreutate.Text);
                    avion_modificat.pret = Int32.Parse(txtPret.Text);
                    avion_modificat.nr_de_pasageri = Int32.Parse(txtNrPasg.Text);
                    if (adminPlanes.UpdateAvion(avion_modificat))
                    {
                        MessageBox.Show("Avionul a fost actualizat cu succes.");
                        // incarcarea datelor

                        // Afișează avioanele în DataGridView folosind BindingList pentru a edita avionul selectat
                       
                        dgvPlane.ClearSelection();
                    }
               
                    else
                        MessageBox.Show("Actualizarea a esuat! ");


                }
                else
                    MessageBox.Show("De selectat avionul pentru a modifica datele");
            }
        }

        private void dgvPlane_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlane.SelectedRows.Count > 0)
            {
                // Se va prelua indexul elementului selectat din DataGridView
                int selectedIndex = dgvPlane.SelectedRows[0].Index;
                // Se va prelua avionul corespunzător indexului selectat
                AvionClass avion = adminPlanes.GetPlane(selectedIndex);
                if (avion != null)
                {
                    // Incarcare date in caseta Txt
                    txtFirma.Text = avion.firma;
                    txtModel.Text = avion.model;
                    txtAnFabricatie.Text = avion.an_fabricatie.ToString();
                    txtCuloare.Text = avion.culoare.ToString();
                    txtGreutate.Text = avion.greutate.ToString();
                    txtPret.Text = avion.pret.ToString();
                    txtNrPasg.Text = avion.nr_de_pasageri.ToString();
                }

            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvPlane.SelectedRows.Count == AVION_NESELECTAT)
            {
                MessageBox.Show("Selectare avionul");
            }
            else
            {
                dgvPlane.DataSource = avioanele;
                if (dgvPlane.SelectedRows.Count == 1)
                {
                    int selectedIndex = dgvPlane.SelectedRows[0].Index;
                    AvionClass avionulSelectat = avioanele[selectedIndex];
                    // Șterge elementul din BindingList
                    dgvPlane.Rows.RemoveAt(selectedIndex);
                    adminPlanes.DeletePlane(avionulSelectat);

                    AfiseazaDateGridAvion(avioanele.ToList());
                }
                else
                    MessageBox.Show("Selecteaza avionul pentru a sterge");

            }
            
        }

        private void CkbComponente_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string componentaSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
           if (checkBoxControl.Checked == true)
                ComponenteSelectate.Add(componentaSelectata);
            else
                ComponenteSelectate.Remove(componentaSelectata);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
           //Incarcare surse de date
            List<AvionClass> avioane = adminPlanes.GetPlanes();

            // Actualizare DataGridView
            AfiseazaDateGridAvion(avioane);
        }
    }
    }
        
  
