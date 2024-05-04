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
        private FormProductAvion AvionProduct;
       
        private Label lblFirma;
        private Label lblModel;
        private Label lblan_fabricatie;
        private Label lblCuloare;
        private Label lblgreutate;
        private Label lblpret;
        private Label lblnr_de_pasageri;

        //vector
         private Label[] lblsFirme;
         private Label[] lblsModele;
         private Label[] lblsan_fabricatie;
         private Label[] lblsCulori;
         private Label[] lblsgreutate;
         private Label[] lblsPret;
         private Label[] lblsnr_de_pasageri;

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
        private Label lblSalvarePlane;
        private Label lblRefresh;

        private const int LATIME_CONTROL = 90;
        private const int LUNGIME_CONTROL = 60;
        private const int DIMENSIUNEA_PAS_X = 100;
        private const int DIMENSIUNEA_PAS_Y = 120;

        public Form1()
        {
            InitializeComponent();





            this.Size = new Size(1200, 720);
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
          
            ///Clasa Avion 
            ///firma
            lblFirma = new Label();
            lblFirma.Height = 40;
            lblFirma.Top = LUNGIME_CONTROL;
            lblFirma.Left = 20;
            lblFirma.Text = "Firma";
            lblFirma.TextAlign = ContentAlignment.MiddleCenter;
            lblFirma.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblFirma.ForeColor = Color.Chocolate;
            lblFirma.BackColor = Color.White;
            lblFirma.Visible = true;
            this.Controls.Add(lblFirma);
            //model
            lblModel = new Label();
            lblModel.Top = LUNGIME_CONTROL;
            lblModel.Left = 140;
            lblModel.Text = "Model";
            lblModel.TextAlign = ContentAlignment.MiddleCenter;
            lblModel.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblModel.ForeColor = Color.Chocolate;
            lblModel.BackColor = Color.White;
            lblModel.Visible = true;
            this.Controls.Add(lblModel);
            //an_fabricatie
            lblan_fabricatie = new Label();
            lblan_fabricatie.Top = LUNGIME_CONTROL;
            lblan_fabricatie.Left = 260;
            lblan_fabricatie.Text = "An_fabricatie";
            lblan_fabricatie.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblan_fabricatie.TextAlign = ContentAlignment.MiddleCenter;
            lblan_fabricatie.ForeColor = Color.Chocolate;
            lblan_fabricatie.BackColor = Color.White;
            lblan_fabricatie.Visible = true;
            this.Controls.Add(lblan_fabricatie);

            //culoare
            lblCuloare = new Label();
            lblCuloare.Top = LUNGIME_CONTROL;
            lblCuloare.Left = 380;
            lblCuloare.Text = "Culoarea";
            lblCuloare.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblCuloare.TextAlign = ContentAlignment.MiddleCenter;
            lblCuloare.ForeColor = Color.Chocolate;
            lblCuloare.BackColor = Color.White;
            lblCuloare.Visible = true;
            this.Controls.Add(lblCuloare);


            //greutate
            lblgreutate = new Label();
            lblgreutate.Top = LUNGIME_CONTROL;
            lblgreutate.Left = 500;
            lblgreutate.Text = "Greutatea";
            lblgreutate.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblgreutate.TextAlign = ContentAlignment.MiddleCenter;
            lblgreutate.ForeColor = Color.Chocolate;
            lblgreutate.BackColor = Color.White;
            lblgreutate.Visible = true;
            this.Controls.Add(lblgreutate);
            //pret
            lblpret = new Label();
            lblpret.Top = LUNGIME_CONTROL;
            lblpret.Left = 600;
            lblpret.Text = "Pretul";
            lblpret.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblpret.TextAlign = ContentAlignment.MiddleCenter;
            lblpret.ForeColor = Color.Chocolate;
            lblpret.BackColor = Color.White;
            lblpret.Visible = true;
            this.Controls.Add(lblpret);
            //nr_de_pasageri
            lblnr_de_pasageri = new Label();
            lblnr_de_pasageri.Top = LUNGIME_CONTROL;
            lblnr_de_pasageri.Left = 700;
            lblnr_de_pasageri.Text = "Nr pasageri";
            lblnr_de_pasageri.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblnr_de_pasageri.TextAlign = ContentAlignment.MiddleCenter;
            lblnr_de_pasageri.ForeColor = Color.Chocolate;
            lblnr_de_pasageri.BackColor = Color.White;
            lblnr_de_pasageri.Visible = true;
            this.Controls.Add(lblnr_de_pasageri);
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

      

        private void Button_ClickProductAvion(object sender,EventArgs e)
        {
            AvionProduct.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaAvioane();
        }
       
        private void AfiseazaAvioane()
        {
            List<AvionClass> avioane = adminPlanes.GetPlanes();
            int nr_avioane = avioane.Count;
             lblsFirme = new Label[nr_avioane];
             lblsModele = new Label[nr_avioane];
             lblsan_fabricatie = new Label[nr_avioane];
             lblsCulori = new Label[nr_avioane];
             lblsgreutate = new Label[nr_avioane];
             lblsPret = new Label[nr_avioane];
             lblsnr_de_pasageri = new Label[nr_avioane];
           // lblsAvioane = new Label[nr_avioane, NUMAR_PROPRIETATI];
        
            int i = 0;
            foreach (AvionClass avion in avioane)
            {
                //adaugare de tip control Label pentru numele firmei
                lblsFirme[i] = new Label();
                lblsFirme[i].Width = LATIME_CONTROL;
                lblsFirme[i].Left = DIMENSIUNEA_PAS_X / 3;
                lblsFirme[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsFirme[i].Text = avion.firma;
                lblsFirme[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsFirme[i].ForeColor = Color.DarkCyan;
                lblsFirme[i].BackColor = Color.White;
                lblsFirme[i].TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(lblsFirme[i]);

                lblsModele[i] = new Label();
                lblsModele[i].Width = LATIME_CONTROL;
                lblsModele[i].Text = avion.model;
                lblsModele[i].Left = 2 * DIMENSIUNEA_PAS_X - 40;
                lblsModele[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsModele[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsModele[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsModele[i].ForeColor = Color.DarkCyan;
                lblsModele[i].BackColor = Color.White;
                this.Controls.Add(lblsModele[i]);

                lblsan_fabricatie[i] = new Label();
                lblsan_fabricatie[i].Width = LATIME_CONTROL;
                lblsan_fabricatie[i].Text = avion.an_fabricatie.ToString();
                lblsan_fabricatie[i].Left = 3 * DIMENSIUNEA_PAS_X - 20;
                lblsan_fabricatie[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsan_fabricatie[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsan_fabricatie[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsan_fabricatie[i].ForeColor = Color.DarkCyan;
                lblsan_fabricatie[i].BackColor = Color.White;
                this.Controls.Add(lblsan_fabricatie[i]);

                lblsCulori[i] = new Label();
                lblsCulori[i].Width = LATIME_CONTROL;
                lblsCulori[i].Text = avion.culoare.ToString();
                lblsCulori[i].Left = 4 * DIMENSIUNEA_PAS_X - 40;
                lblsCulori[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsCulori[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsCulori[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsCulori[i].ForeColor = Color.DarkCyan;
                lblsCulori[i].BackColor = Color.White;
                this.Controls.Add(lblsCulori[i]);

                lblsgreutate[i] = new Label();
                lblsgreutate[i].Width = LATIME_CONTROL;
                lblsgreutate[i].Text = avion.greutate.ToString();
                lblsgreutate[i].Left = 5 * DIMENSIUNEA_PAS_X;
                lblsgreutate[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsgreutate[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsgreutate[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsgreutate[i].ForeColor = Color.DarkCyan;
                lblsgreutate[i].BackColor = Color.White;
                this.Controls.Add(lblsgreutate[i]);


                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = avion.pret.ToString();
                lblsPret[i].Left = 6 * DIMENSIUNEA_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsPret[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsPret[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsPret[i].ForeColor = Color.DarkCyan;
                lblsPret[i].BackColor = Color.White;
                this.Controls.Add(lblsPret[i]);



                lblsnr_de_pasageri[i] = new Label();
                lblsnr_de_pasageri[i].Width = LATIME_CONTROL;
                lblsnr_de_pasageri[i].Text = avion.nr_de_pasageri.ToString();
                lblsnr_de_pasageri[i].Left = 7 * DIMENSIUNEA_PAS_X + 10;
                lblsnr_de_pasageri[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y / 2 + 40;
                lblsnr_de_pasageri[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsnr_de_pasageri[i].ForeColor = Color.DarkCyan;
                lblsnr_de_pasageri[i].TextAlign = ContentAlignment.MiddleCenter;
                lblsnr_de_pasageri[i].BackColor = Color.White;
                this.Controls.Add(lblsnr_de_pasageri[i]);
                i++;
                
            }

        }
        private void ButoaneAvioane()
        {
           
           
           

            lblSalvarePlane = new Label();
            lblSalvarePlane.Width = LUNGIME_CONTROL * 3;
            lblSalvarePlane.Height = LATIME_CONTROL;
            lblSalvarePlane.Left = DIMENSIUNEA_PAS_X * 9 + 10;
            lblSalvarePlane.Top = 330;
            lblSalvarePlane.Text = " ";
            lblSalvarePlane.BackColor = Color.Aqua;
            this.Controls.Add(lblSalvarePlane);

           
            btnAdaugaAvioane.Click += OnButtonClicked;
            btnRefresh.Click += OnButton2Clicked;


            lblRefresh = new Label();
            lblRefresh.Width = LUNGIME_CONTROL * 3;
            lblRefresh.Height = LATIME_CONTROL;
            lblRefresh.Left = DIMENSIUNEA_PAS_X * 9 + 10;
            lblRefresh.Top = 360;
            lblRefresh.Text = " ";
            lblRefresh.BackColor = Color.Aqua;
            this.Controls.Add(lblRefresh);


            

        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            bool valid = true;
        
            int an_fabricatie;
            Culoarea culoare;
            decimal greutate;
            decimal pret;
            int nr_pasageri;
             txtIntroducereFirma.Text.ToString();
             txtIntroducereModel.Text.ToString();
            bool an_FabricatieValid = Int32.TryParse(txtIntroducereAnFabricatie.Text.ToString(), out an_fabricatie);
            bool culoareValid = Enum.TryParse(txtIntroduceCuloare.Text.ToString(), out culoare);
            bool greutateValid = Decimal.TryParse(txtIntroduceregreutate.Text.ToString(), out greutate);
            bool pretValid=Decimal.TryParse(txtIntroducepret.Text.ToString(), out pret);
             bool nr_pasgariValid= Int32.TryParse(txtIntroducerenrpasg.Text.ToString(), out nr_pasageri);
            AvionClass avion = new AvionClass(0, txtIntroducereFirma.Text.ToString(),txtIntroducereModel.Text.ToString(),an_fabricatie,culoare,greutate,pret,nr_pasageri);
                                             
     
            
            if (txtIntroducereFirma.Text.ToString() == "" || txtIntroducereFirma.Text.ToString() == "Obligatoriu!")
            {
                txtIntroducereFirma.Text = "Obligatoriu!";
                txtIntroducereFirma.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtIntroducereFirma.Text.Length <2||txtIntroducereFirma.Text.Length > 20)
            {
                txtIntroducereFirma.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroducereFirma.ForeColor = Color.Black;
            if (txtIntroducereModel.Text.ToString() == "" || txtIntroducereModel.Text.ToString() == "Obligatoriu!")
            {
                txtIntroducereModel.Text = "Obligatoriu!";
                txtIntroducereModel.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtIntroducereFirma.Text.Length > 20)
            {
                txtIntroducereModel.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroducereModel.ForeColor = Color.Black;

            if (txtIntroducereAnFabricatie.Text.ToString() == "" || txtIntroducereAnFabricatie.Text.ToString() =="Obligatoriu!")
            {
                txtIntroducereAnFabricatie.Text = "Obligatoriu!";
                txtIntroducereAnFabricatie.ForeColor = Color.Red;
                valid = false;
            }
            else if (txtIntroducereAnFabricatie.Text.Length > 4)
            {
                txtIntroducereAnFabricatie.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroducereFirma.ForeColor = Color.Black;

            if (txtIntroduceCuloare.Text.ToString() == "" || txtIntroduceCuloare.Text.ToString() == "Obligatoriu!")
            {
                txtIntroduceCuloare.Text = "Obligatoriu!";
                txtIntroduceCuloare.ForeColor = Color.Red;
                valid = false;

            }
            else if (txtIntroduceCuloare.Text.Length > 30)
            {

                txtIntroduceCuloare.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroduceCuloare.ForeColor = Color.Black;

            if (txtIntroduceregreutate.Text.ToString() == "" || txtIntroduceregreutate.Text.ToString() == "Obligatoriu!")
            {
                txtIntroduceCuloare.Text = "Obligatoriu";
                txtIntroduceCuloare.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroduceregreutate.ForeColor = Color.Black;

            if (txtIntroducepret.Text.ToString() == "" || txtIntroducepret.Text.ToString() == "Obligatoriu!")
            {
                txtIntroducepret.Text = "Obligatoriu";
                txtIntroducepret.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroducepret.ForeColor = Color.Black;

            if (txtIntroducerenrpasg.Text.ToString() == "" || txtIntroducerenrpasg.Text.ToString() == "Obligatoriu!")
            {
                txtIntroducerenrpasg.Text = "Obligatoriu";
                txtIntroducerenrpasg.ForeColor = Color.Red;
                valid = false;
            }
            else
                txtIntroducerenrpasg.ForeColor = Color.Black;


            ///verificariile
            if (valid)
            {
                adminPlanes.AddPlane(avion);
                lblSalvarePlane.Text = "Avion adaugat";
            }
            else
            {
                lblSalvarePlane.Text = "Informatiile sunt introduse incorect";
            }
        }
          
        
        private void OnButton2Clicked(object sender,EventArgs e)
        {
            AfiseazaAvioane();
            lblRefresh.Text = "Datele despre avioane au fost actualizate";
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
    }
}
