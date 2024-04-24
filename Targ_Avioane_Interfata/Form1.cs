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

namespace Targ_Avioane_Interfata
{
    public partial class Form1 : Form
    {
        private AdministrareAvioane_FisierText adminPlanes;
        private Label lbltitlu;  //Titlul proiectului (Targul de avioane)
        //Constructurul  cu parametrii din clasa avion

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

        private Label lblIntroducereFirma;
        private TextBox txtIntroducereFirma;

        private Label lblIntroducereModel;
        private TextBox txtIntroducereModel;

        private Label lblIntroducereAnFabricatie;
        private TextBox txtIntroducereAnFabricatie;

        private Label lblIntroducereCuloare;
        private TextBox txtIntroduceCuloare;

        private Label lblIntroduceregreutate;
        private TextBox txtIntroduceregreutate;

        private Label lblIntroducerepret;
        private TextBox txtIntroducepret;

        private Label lblIntroducerenrpasg;  //numarul de pasageri
        private TextBox txtIntroducerenrpasg;
        //butoanele

        private Button btnAdaugaAvioane;
        private Button btnRefresh;
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


            lbltitlu = new Label();
            lbltitlu.Top = 20;
            lbltitlu.BackColor = Color.Bisque;
            lbltitlu.Left = DIMENSIUNEA_PAS_X * 3;
            lbltitlu.Width = DIMENSIUNEA_PAS_X * 2;
            lbltitlu.Text = "Targul de avioane";
            lbltitlu.Font = new Font("Arial", 16, FontStyle.Bold);
            lbltitlu.ForeColor = Color.SkyBlue;
            this.Controls.Add(lbltitlu);



            this.Size = new Size(1200, 720);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Times New Roman", 8, FontStyle.Regular);
            this.ForeColor = Color.LimeGreen;
            this.Text = "BussinesPlaneUP";
            this.BackColor = Color.Azure;
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
            int nr_avioane = 0;
            AvionClass[] avioane = adminPlanes.GetPlanes(out nr_avioane);

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
            this.Controls.Add(lblnr_de_pasageri);


            this.FormClosed += OnFormClosed;

            ButoaneAvioane();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaAvioane();
        }

        private void AfiseazaAvioane()
        {
            AvionClass[] avioane = adminPlanes.GetPlanes(out int nr_avioane);
            lblsFirme = new Label[nr_avioane];
            lblsModele = new Label[nr_avioane];
            lblsan_fabricatie = new Label[nr_avioane];
            lblsCulori = new Label[nr_avioane];
            lblsgreutate = new Label[nr_avioane];
            lblsPret = new Label[nr_avioane];
            lblsnr_de_pasageri = new Label[nr_avioane];
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
            lblIntroducereFirma = new Label();
            lblIntroducereFirma.Width = LUNGIME_CONTROL;
            lblIntroducereFirma.Height = LATIME_CONTROL / 3;
            lblIntroducereFirma.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroducereFirma.Top = 40;
            lblIntroducereFirma.Text = "Firma:";
            lblIntroducereFirma.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroducereFirma);

            txtIntroducereFirma = new TextBox();
            txtIntroducereFirma.Width = LUNGIME_CONTROL * 3;
            txtIntroducereFirma.Height = LATIME_CONTROL * 2;
            txtIntroducereFirma.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroducereFirma.Top = 40;

            this.Controls.Add(txtIntroducereFirma);
            //Introducere de date model

            lblIntroducereModel = new Label();
            lblIntroducereModel.Width = LUNGIME_CONTROL;
            lblIntroducereModel.Height = LATIME_CONTROL / 3;
            lblIntroducereModel.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroducereModel.Top = 70;
            lblIntroducereModel.Text = "Model:";
            lblIntroducereModel.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroducereModel);

            txtIntroducereModel = new TextBox();
            txtIntroducereModel.Width = LUNGIME_CONTROL * 3;
            txtIntroducereModel.Height = LATIME_CONTROL * 2;
            txtIntroducereModel.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroducereModel.Top = 70;
            this.Controls.Add(txtIntroducereModel);

            ///Introducere anfabricatie
            lblIntroducereAnFabricatie = new Label();
            lblIntroducereAnFabricatie.Width = LUNGIME_CONTROL;
            lblIntroducereAnFabricatie.Height = LATIME_CONTROL / 3;
            lblIntroducereAnFabricatie.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroducereAnFabricatie.Top = 100;
            lblIntroducereAnFabricatie.Text = "An fabricatie:";
            lblIntroducereAnFabricatie.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroducereAnFabricatie);

            //caseta anfabricatie
            txtIntroducereAnFabricatie = new TextBox();
            txtIntroducereAnFabricatie.Width = LUNGIME_CONTROL * 3;
            txtIntroducereAnFabricatie.Height = LATIME_CONTROL * 2;
            txtIntroducereAnFabricatie.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroducereAnFabricatie.Top = 100;
            this.Controls.Add(txtIntroducereAnFabricatie);

            //Introducere Culoare
            lblIntroducereCuloare = new Label();
            lblIntroducereCuloare.Width = LUNGIME_CONTROL;
            lblIntroducereCuloare.Height = LATIME_CONTROL / 3;
            lblIntroducereCuloare.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroducereCuloare.Top = 130;
            lblIntroducereCuloare.Text = "Culoare:";
            lblIntroducereCuloare.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroducereCuloare);

            txtIntroduceCuloare = new TextBox();
            txtIntroduceCuloare.Width = LUNGIME_CONTROL * 3;
            txtIntroduceCuloare.Height = LATIME_CONTROL * 2;
            txtIntroduceCuloare.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroduceCuloare.Top = 130;
            this.Controls.Add(txtIntroduceCuloare);

            lblIntroduceregreutate = new Label();
            lblIntroduceregreutate.Width = LUNGIME_CONTROL;
            lblIntroduceregreutate.Height = LATIME_CONTROL / 3;
            lblIntroduceregreutate.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroduceregreutate.Top = 160;
            lblIntroduceregreutate.Text = "Greutatatea:";
            lblIntroduceregreutate.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroduceregreutate);

            txtIntroduceregreutate = new TextBox();
            txtIntroduceregreutate.Width = LUNGIME_CONTROL * 3;
            txtIntroduceregreutate.Height = LATIME_CONTROL * 2;
            txtIntroduceregreutate.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroduceregreutate.Top = 160;
            this.Controls.Add(txtIntroduceregreutate);

            lblIntroducerepret = new Label();
            lblIntroducerepret.Width = LUNGIME_CONTROL;
            lblIntroducerepret.Height = LATIME_CONTROL / 3;
            lblIntroducerepret.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroducerepret.Top = 190;
            lblIntroducerepret.Text = "Pret:";
            lblIntroducerepret.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroducerepret);

            txtIntroducepret = new TextBox();
            txtIntroducepret.Width = LUNGIME_CONTROL * 3;
            txtIntroducepret.Height = LATIME_CONTROL * 2;
            txtIntroducepret.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroducepret.Top = 190;
            this.Controls.Add(txtIntroducepret);

            lblIntroducerenrpasg = new Label();
            lblIntroducerenrpasg.Width = LUNGIME_CONTROL;
            lblIntroducerenrpasg.Height = LATIME_CONTROL / 3;
            lblIntroducerenrpasg.Left = DIMENSIUNEA_PAS_X * 8 + 20;
            lblIntroducerenrpasg.Top = 220;
            lblIntroducerenrpasg.Text = "Numar de pasageri:";
            lblIntroducerenrpasg.BackColor = Color.Aqua;
            this.Controls.Add(lblIntroducerenrpasg);

            txtIntroducerenrpasg = new TextBox();
            txtIntroducerenrpasg.Width = LUNGIME_CONTROL * 3;
            txtIntroducerenrpasg.Height = LATIME_CONTROL * 2;
            txtIntroducerenrpasg.Left = DIMENSIUNEA_PAS_X * 9 - 80;
            txtIntroducerenrpasg.Top = 220;
            this.Controls.Add(txtIntroducerenrpasg);

            lblSalvarePlane = new Label();
            lblSalvarePlane.Width = LUNGIME_CONTROL * 3;
            lblSalvarePlane.Height = LATIME_CONTROL;
            lblSalvarePlane.Left = DIMENSIUNEA_PAS_X * 9 + 10;
            lblSalvarePlane.Top = 250;
            lblSalvarePlane.Text = " ";
            lblSalvarePlane.BackColor = Color.Aqua;
            this.Controls.Add(lblSalvarePlane);

            btnAdaugaAvioane = new Button();
            btnAdaugaAvioane.Height = LUNGIME_CONTROL;
            btnAdaugaAvioane.Width = LATIME_CONTROL;
            btnAdaugaAvioane.Location = new System.Drawing.Point(DIMENSIUNEA_PAS_X * 8 + 20, 0);
            btnAdaugaAvioane.Top = 250;
            btnAdaugaAvioane.Text = "&Adauga";
            btnAdaugaAvioane.BackColor = Color.Orange;

            btnAdaugaAvioane.Click += OnButtonClicked;
            this.Controls.Add(btnAdaugaAvioane);


            lblRefresh = new Label();
            lblRefresh.Width = LUNGIME_CONTROL * 3;
            lblRefresh.Height = LATIME_CONTROL;
            lblRefresh.Left = DIMENSIUNEA_PAS_X * 9 + 10;
            lblRefresh.Top = 280;
            lblRefresh.Text = " ";
            lblRefresh.BackColor = Color.Aqua;
            this.Controls.Add(lblRefresh);


            btnRefresh = new Button();
            btnRefresh.Height = LUNGIME_CONTROL;
            btnRefresh.Width = LATIME_CONTROL;
            btnRefresh.Location = new System.Drawing.Point(DIMENSIUNEA_PAS_X * 8 + 20, 0);
            btnRefresh.Top = 310;
            btnRefresh.Text = "&Refresh";
            btnRefresh.BackColor = Color.Orange;
            this.Controls.Add(btnRefresh);

        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            bool valid = true;
            AvionClass avion = new AvionClass(0, 
                                              txtIntroducereFirma.Text.ToString(),
                                              txtIntroducereModel.Text.ToString(), 
                                              Convert.ToInt32(txtIntroducereAnFabricatie.Text.ToString()),
                                              (Culoarea)Enum.Parse(typeof(Culoarea), txtIntroduceCuloare.Text.ToString()),
                                              Convert.ToDecimal(txtIntroduceregreutate.Text.ToString()), 
                                              Convert.ToDecimal(txtIntroducepret.Text.ToString()),
                                              Convert.ToInt32(txtIntroducerenrpasg.Text.ToString()));

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
          
        
        
        private void OnFormClosed(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}
