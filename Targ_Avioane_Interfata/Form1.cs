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
        public Form1()
        {
            InitializeComponent();


            Label lbltitlu = new Label();
            lbltitlu.Top = 20;
            lbltitlu.Left = 300;
            lbltitlu.Text = "Targul de avioane";
            this.Controls.Add(lbltitlu);



            this.Size = new Size(700, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "BussinesPlaneUP";

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie =  Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareAvioane_FisierText adminPlanes= new AdministrareAvioane_FisierText(caleCompletaFisier);
            int nr_avioane= 0;
            AvionClass[] avioane = adminPlanes.GetPlanes(out  nr_avioane);

            ///Clasa Avion 
            ///firma
            Label lbFirma = new Label();
            lbFirma.Top = 80;
            lbFirma.Left = 20;
            lbFirma.Text = "Firma";
            this.Controls.Add(lbFirma);
            //model
            Label lbModel = new Label();
            lbModel.Top = 80;
            lbModel.Left = 140;
            lbModel.Text = "Model";
            this.Controls.Add(lbModel);
            //an_fabricatie
            Label lban_fabricatie = new Label();
            lban_fabricatie.Top = 80;
            lban_fabricatie.Left = 260;
            lban_fabricatie.Text = "An_fabricatie";
            this.Controls.Add(lban_fabricatie);

            //culoare
            Label lbCuloare = new Label();
            lbCuloare.Top = 80;
            lbCuloare.Left = 380;
            lbCuloare.Text = "Culoarea";
            this.Controls.Add(lbCuloare);

            //pret
            Label lbpret = new Label();
            lbpret.Top = 80;
            lbpret.Left = 500;
            lbpret.Text = "Pretul";
            this.Controls.Add(lbpret);
            //greutate
            Label lbgreutate = new Label();
            lbgreutate.Top = 80;
            lbgreutate.Left = 600;
            lbgreutate.Text = "Greutatea";
            this.Controls.Add(lbgreutate);
            //nr_de_pasageri
            Label lbnr_de_pasgeri = new Label();
            lbnr_de_pasgeri.Top = 80;
            lbnr_de_pasgeri.Left = 700;
            lbnr_de_pasgeri.Text = "Nr pasageri";
            this.Controls.Add(lbnr_de_pasgeri);

        }
    }
}
