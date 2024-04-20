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


        private Label[] lblsFirme;
        private Label[] lblsModele;
        private Label[] lblsan_fabricatie;
        private Label[] lblsCulori;
        private Label[] lblsgreutate;
        private Label[] lblsPret;
        private Label[] lblsnr_de_pasageri;
        

        private Button btnAdaugaAvioane;
        private Button btnRefresh;


        private const int LATIME_CONTROL = 60;
        private const int LUNGIME_CONTROL = 80;
        private const int DIMENSIUNEA_PAS_X = 100;
        private const int DIMENSIUNEA_PAS_Y = 120;
      
        public Form1()
        {
            InitializeComponent();
            

            lbltitlu = new Label();
            lbltitlu.Top = 20;
            lbltitlu.BackColor = Color.Bisque;
            lbltitlu.Left = DIMENSIUNEA_PAS_X*3;
            lbltitlu.Width = DIMENSIUNEA_PAS_X*2;
            lbltitlu.Text = "Targul de avioane";
            lbltitlu.Font = new Font("Arial", 16, FontStyle.Bold);
            lbltitlu.ForeColor=Color.SkyBlue;
            this.Controls.Add(lbltitlu);



            this.Size = new Size(900, 800);
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
            string locatieFisierSolutie =  Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminPlanes= new AdministrareAvioane_FisierText(caleCompletaFisier);
            int nr_avioane= 0;
            AvionClass[] avioane = adminPlanes.GetPlanes(out  nr_avioane);

            ///Clasa Avion 
            ///firma
            lblFirma = new Label();
            lblFirma.Top = LUNGIME_CONTROL;
            lblFirma.Left = 20;
            lblFirma.Text = "Firma";
            lblFirma.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblFirma.ForeColor = Color.Chocolate;
            this.Controls.Add(lblFirma);
            //model
            lblModel = new Label();
            lblModel.Top = LUNGIME_CONTROL;
            lblModel.Left = 140;
            lblModel.Text = "Model";
            lblModel.Font = new Font("Times New Roman",12,FontStyle.Italic);
            lblModel.ForeColor = Color.Chocolate;
            this.Controls.Add(lblModel);
            //an_fabricatie
            lblan_fabricatie = new Label();
            lblan_fabricatie.Top = LUNGIME_CONTROL;
            lblan_fabricatie.Left = 260;
            lblan_fabricatie.Text = "An_fabricatie";
            lblan_fabricatie.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblan_fabricatie.ForeColor = Color.Chocolate;
            this.Controls.Add(lblan_fabricatie);

            //culoare
            lblCuloare = new Label();
            lblCuloare.Top = LUNGIME_CONTROL;
            lblCuloare.Left = 380;
            lblCuloare.Text = "Culoarea";
            lblCuloare.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblCuloare.ForeColor=Color.Chocolate;
            this.Controls.Add(lblCuloare);

            
            //greutate
            lblgreutate = new Label();
            lblgreutate.Top = LUNGIME_CONTROL;
            lblgreutate.Left = 500;
            lblgreutate.Text = "Greutatea";
            lblgreutate.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblgreutate.ForeColor = Color.Chocolate;
            this.Controls.Add(lblgreutate);
            //pret
            lblpret = new Label();
            lblpret.Top = LUNGIME_CONTROL;
            lblpret.Left = 600;
            lblpret.Text = "Pretul";
            lblpret.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblpret.ForeColor = Color.Chocolate;
            this.Controls.Add(lblpret);
            //nr_de_pasageri
            lblnr_de_pasageri = new Label();
            lblnr_de_pasageri.Top = LUNGIME_CONTROL;
            lblnr_de_pasageri.Left = 700;
            lblnr_de_pasageri.Text = "Nr pasageri";
            lblnr_de_pasageri.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            lblnr_de_pasageri.ForeColor = Color.Chocolate;
            this.Controls.Add(lblnr_de_pasageri);

           // this.FormClosed += OnFormClosed;



        }
        
        private void Form1_Load(object sender,EventArgs e)
        {
            AfiseazaAvioane();
        }
      
        private void AfiseazaAvioane()
        {
            AvionClass[] avioane =adminPlanes.GetPlanes(out int nr_avioane);
            lblsFirme = new Label[nr_avioane];
            lblsModele = new Label[nr_avioane];
            lblsan_fabricatie = new Label[nr_avioane];
            lblsCulori = new Label[nr_avioane];
            lblsgreutate = new Label[nr_avioane];
            lblsPret = new Label[nr_avioane];
            lblsnr_de_pasageri = new Label[nr_avioane];
            int i = 0;
            foreach(AvionClass avion in avioane)
            {
                //adaugare de tip control Label pentru numele firmei
                lblsFirme[i] = new Label();
                lblsFirme[i].Width =LATIME_CONTROL;
                lblsFirme[i].Left = DIMENSIUNEA_PAS_X;
                lblsFirme[i].Top = (i + 1) *DIMENSIUNEA_PAS_Y;
                lblsFirme[i].Text = avion.firma;
                lblsFirme[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsFirme[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsFirme[i]);

                lblsModele[i] = new Label();
                lblsModele[i].Width = LATIME_CONTROL;
                lblsModele[i].Text = avion.model;
                lblsModele[i].Left = 2*DIMENSIUNEA_PAS_X;
                lblsModele[i].Top = (i + 1) *DIMENSIUNEA_PAS_Y;
                lblsModele[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsModele[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsModele[i]);

                lblsan_fabricatie[i] = new Label();
                lblsan_fabricatie[i].Width = LATIME_CONTROL;
                lblsan_fabricatie[i].Text = avion.an_fabricatie.ToString();
                lblsan_fabricatie[i].Left =3*DIMENSIUNEA_PAS_X;
                lblsan_fabricatie[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y;
                lblsan_fabricatie[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsan_fabricatie[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsan_fabricatie[i]);

                lblsCulori[i] = new Label();
                lblsCulori[i].Width =LATIME_CONTROL;
                lblsCulori[i].Text = avion.culoare.ToString();
                lblsCulori[i].Left = 4 * DIMENSIUNEA_PAS_X;
                lblsCulori[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y;
                lblsCulori[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsCulori[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsCulori[i]);

                lblsgreutate[i] = new Label();
                lblsgreutate[i].Width = LATIME_CONTROL;
                lblsgreutate[i].Text = avion.greutate.ToString();
                lblsgreutate[i].Left = 5 * DIMENSIUNEA_PAS_X;
                lblsgreutate[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y;
                lblsgreutate[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsgreutate[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsgreutate[i]);


                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = avion.pret.ToString();
                lblsPret[i].Left = 6 * DIMENSIUNEA_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y;
                lblsPret[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsPret[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsPret[i]);



                lblsnr_de_pasageri[i] = new Label();
                lblsnr_de_pasageri[i].Width =LATIME_CONTROL;
                lblsnr_de_pasageri[i].Text = avion.nr_de_pasageri.ToString();
                lblsnr_de_pasageri[i].Left = 7 * DIMENSIUNEA_PAS_X;
                lblsnr_de_pasageri[i].Top = (i + 1) * DIMENSIUNEA_PAS_Y;
                lblsnr_de_pasageri[i].Font = new Font("Times New Roman", 9, FontStyle.Regular);
                lblsnr_de_pasageri[i].ForeColor = Color.DarkCyan;
                this.Controls.Add(lblsnr_de_pasageri[i]);

                i++;
            }

        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
