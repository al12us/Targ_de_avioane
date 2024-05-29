namespace Targ_Avioane_Interfata
{
    partial class FormProductAvion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnBackMainMenu_1;
            this.lblTitluProductAvion = new System.Windows.Forms.Label();
            this.lblCompanie = new System.Windows.Forms.Label();
            this.lblTaraOrigine = new System.Windows.Forms.Label();
            this.lblAnInfiintare = new System.Windows.Forms.Label();
            this.lblnrAngajati = new System.Windows.Forms.Label();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.lstProductPlane = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStergeProductPlane = new System.Windows.Forms.Button();
            this.btnRefreshProductPlane = new System.Windows.Forms.Button();
            this.btnAdaugaProductPlane = new System.Windows.Forms.Button();
            this.txtNrAngajati = new System.Windows.Forms.TextBox();
            this.txtAnInfiintare = new System.Windows.Forms.TextBox();
            this.txtTaraOrigine = new System.Windows.Forms.TextBox();
            this.txtCompanie = new System.Windows.Forms.TextBox();
            this.lblRefreshProductPlane = new System.Windows.Forms.Label();
            this.lblSalvareProductPlane = new System.Windows.Forms.Label();
            this.ckbCivil = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbComercial = new System.Windows.Forms.CheckBox();
            this.ckbMilitar = new System.Windows.Forms.CheckBox();
            this.cbkExperimental = new System.Windows.Forms.CheckBox();
            btnBackMainMenu_1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackMainMenu_1
            // 
            btnBackMainMenu_1.BackColor = System.Drawing.Color.Lime;
            btnBackMainMenu_1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            btnBackMainMenu_1.FlatAppearance.BorderSize = 3;
            btnBackMainMenu_1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnBackMainMenu_1.ForeColor = System.Drawing.Color.SaddleBrown;
            btnBackMainMenu_1.Location = new System.Drawing.Point(973, 543);
            btnBackMainMenu_1.Name = "btnBackMainMenu_1";
            btnBackMainMenu_1.Size = new System.Drawing.Size(197, 44);
            btnBackMainMenu_1.TabIndex = 8;
            btnBackMainMenu_1.Text = "Înapoi în meniu principal";
            btnBackMainMenu_1.UseVisualStyleBackColor = false;
            btnBackMainMenu_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitluProductAvion
            // 
            this.lblTitluProductAvion.AutoSize = true;
            this.lblTitluProductAvion.BackColor = System.Drawing.Color.Lime;
            this.lblTitluProductAvion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitluProductAvion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitluProductAvion.Location = new System.Drawing.Point(319, 70);
            this.lblTitluProductAvion.Name = "lblTitluProductAvion";
            this.lblTitluProductAvion.Size = new System.Drawing.Size(263, 27);
            this.lblTitluProductAvion.TabIndex = 0;
            this.lblTitluProductAvion.Text = "Producător de avioane";
            this.lblTitluProductAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanie
            // 
            this.lblCompanie.AutoSize = true;
            this.lblCompanie.BackColor = System.Drawing.Color.Azure;
            this.lblCompanie.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanie.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCompanie.Location = new System.Drawing.Point(49, 21);
            this.lblCompanie.Name = "lblCompanie";
            this.lblCompanie.Size = new System.Drawing.Size(78, 20);
            this.lblCompanie.TabIndex = 1;
            this.lblCompanie.Text = "Companie";
            this.lblCompanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaraOrigine
            // 
            this.lblTaraOrigine.AutoSize = true;
            this.lblTaraOrigine.BackColor = System.Drawing.Color.Azure;
            this.lblTaraOrigine.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaraOrigine.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTaraOrigine.Location = new System.Drawing.Point(14, 50);
            this.lblTaraOrigine.Name = "lblTaraOrigine";
            this.lblTaraOrigine.Size = new System.Drawing.Size(116, 21);
            this.lblTaraOrigine.TabIndex = 2;
            this.lblTaraOrigine.Text = "Țara de Origine";
            // 
            // lblAnInfiintare
            // 
            this.lblAnInfiintare.AutoSize = true;
            this.lblAnInfiintare.BackColor = System.Drawing.Color.Azure;
            this.lblAnInfiintare.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnInfiintare.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAnInfiintare.Location = new System.Drawing.Point(83, 79);
            this.lblAnInfiintare.Name = "lblAnInfiintare";
            this.lblAnInfiintare.Size = new System.Drawing.Size(44, 21);
            this.lblAnInfiintare.TabIndex = 3;
            this.lblAnInfiintare.Text = "Anul";
            this.lblAnInfiintare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnrAngajati
            // 
            this.lblnrAngajati.AutoSize = true;
            this.lblnrAngajati.BackColor = System.Drawing.Color.Azure;
            this.lblnrAngajati.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnrAngajati.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblnrAngajati.Location = new System.Drawing.Point(42, 106);
            this.lblnrAngajati.Name = "lblnrAngajati";
            this.lblnrAngajati.Size = new System.Drawing.Size(85, 42);
            this.lblnrAngajati.TabIndex = 4;
            this.lblnrAngajati.Text = "Număr de \r\nangajați";
            this.lblnrAngajati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.BackColor = System.Drawing.Color.Azure;
            this.lblSpecializare.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecializare.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSpecializare.Location = new System.Drawing.Point(37, 155);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(90, 21);
            this.lblSpecializare.TabIndex = 5;
            this.lblSpecializare.Text = "Specializare";
            // 
            // lstProductPlane
            // 
            this.lstProductPlane.FormattingEnabled = true;
            this.lstProductPlane.ItemHeight = 16;
            this.lstProductPlane.Location = new System.Drawing.Point(39, 119);
            this.lstProductPlane.Name = "lstProductPlane";
            this.lstProductPlane.Size = new System.Drawing.Size(792, 276);
            this.lstProductPlane.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnStergeProductPlane);
            this.panel1.Controls.Add(this.btnRefreshProductPlane);
            this.panel1.Controls.Add(this.btnAdaugaProductPlane);
            this.panel1.Controls.Add(this.txtNrAngajati);
            this.panel1.Controls.Add(this.txtAnInfiintare);
            this.panel1.Controls.Add(this.txtTaraOrigine);
            this.panel1.Controls.Add(this.txtCompanie);
            this.panel1.Controls.Add(this.lblSpecializare);
            this.panel1.Controls.Add(this.lblnrAngajati);
            this.panel1.Controls.Add(this.lblAnInfiintare);
            this.panel1.Controls.Add(this.lblTaraOrigine);
            this.panel1.Controls.Add(this.lblCompanie);
            this.panel1.Location = new System.Drawing.Point(854, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 380);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(119, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Caută";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lime;
            this.btnReset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReset.Location = new System.Drawing.Point(119, 312);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStergeProductPlane
            // 
            this.btnStergeProductPlane.BackColor = System.Drawing.Color.Lime;
            this.btnStergeProductPlane.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnStergeProductPlane.FlatAppearance.BorderSize = 3;
            this.btnStergeProductPlane.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStergeProductPlane.Location = new System.Drawing.Point(18, 341);
            this.btnStergeProductPlane.Name = "btnStergeProductPlane";
            this.btnStergeProductPlane.Size = new System.Drawing.Size(75, 23);
            this.btnStergeProductPlane.TabIndex = 15;
            this.btnStergeProductPlane.Text = "&Șterge";
            this.btnStergeProductPlane.UseVisualStyleBackColor = false;
            this.btnStergeProductPlane.Click += new System.EventHandler(this.btnStergeProductPlane_Click);
            // 
            // btnRefreshProductPlane
            // 
            this.btnRefreshProductPlane.BackColor = System.Drawing.Color.Lime;
            this.btnRefreshProductPlane.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRefreshProductPlane.Location = new System.Drawing.Point(18, 312);
            this.btnRefreshProductPlane.Name = "btnRefreshProductPlane";
            this.btnRefreshProductPlane.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshProductPlane.TabIndex = 12;
            this.btnRefreshProductPlane.Text = "&Refresh";
            this.btnRefreshProductPlane.UseVisualStyleBackColor = false;
            this.btnRefreshProductPlane.Click += new System.EventHandler(this.btnRefreshProductPlane_Click);
            // 
            // btnAdaugaProductPlane
            // 
            this.btnAdaugaProductPlane.BackColor = System.Drawing.Color.Lime;
            this.btnAdaugaProductPlane.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdaugaProductPlane.Location = new System.Drawing.Point(18, 283);
            this.btnAdaugaProductPlane.Name = "btnAdaugaProductPlane";
            this.btnAdaugaProductPlane.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaProductPlane.TabIndex = 11;
            this.btnAdaugaProductPlane.Text = "&Adaugă";
            this.btnAdaugaProductPlane.UseVisualStyleBackColor = false;
            this.btnAdaugaProductPlane.Click += new System.EventHandler(this.btnAdaugaProductPlane_Click);
            // 
            // txtNrAngajati
            // 
            this.txtNrAngajati.Location = new System.Drawing.Point(170, 117);
            this.txtNrAngajati.Name = "txtNrAngajati";
            this.txtNrAngajati.Size = new System.Drawing.Size(159, 22);
            this.txtNrAngajati.TabIndex = 9;
            // 
            // txtAnInfiintare
            // 
            this.txtAnInfiintare.Location = new System.Drawing.Point(170, 78);
            this.txtAnInfiintare.Name = "txtAnInfiintare";
            this.txtAnInfiintare.Size = new System.Drawing.Size(159, 22);
            this.txtAnInfiintare.TabIndex = 8;
            // 
            // txtTaraOrigine
            // 
            this.txtTaraOrigine.Location = new System.Drawing.Point(170, 50);
            this.txtTaraOrigine.Name = "txtTaraOrigine";
            this.txtTaraOrigine.Size = new System.Drawing.Size(159, 22);
            this.txtTaraOrigine.TabIndex = 7;
            // 
            // txtCompanie
            // 
            this.txtCompanie.Location = new System.Drawing.Point(170, 21);
            this.txtCompanie.Name = "txtCompanie";
            this.txtCompanie.Size = new System.Drawing.Size(159, 22);
            this.txtCompanie.TabIndex = 6;
            // 
            // lblRefreshProductPlane
            // 
            this.lblRefreshProductPlane.AutoSize = true;
            this.lblRefreshProductPlane.Location = new System.Drawing.Point(961, 503);
            this.lblRefreshProductPlane.Name = "lblRefreshProductPlane";
            this.lblRefreshProductPlane.Size = new System.Drawing.Size(0, 16);
            this.lblRefreshProductPlane.TabIndex = 14;
            // 
            // lblSalvareProductPlane
            // 
            this.lblSalvareProductPlane.AutoSize = true;
            this.lblSalvareProductPlane.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSalvareProductPlane.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSalvareProductPlane.Location = new System.Drawing.Point(947, 471);
            this.lblSalvareProductPlane.Name = "lblSalvareProductPlane";
            this.lblSalvareProductPlane.Size = new System.Drawing.Size(0, 16);
            this.lblSalvareProductPlane.TabIndex = 13;
            // 
            // ckbCivil
            // 
            this.ckbCivil.AutoSize = true;
            this.ckbCivil.Location = new System.Drawing.Point(6, 21);
            this.ckbCivil.Name = "ckbCivil";
            this.ckbCivil.Size = new System.Drawing.Size(54, 20);
            this.ckbCivil.TabIndex = 15;
            this.ckbCivil.Text = "Civil";
            this.ckbCivil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkExperimental);
            this.groupBox1.Controls.Add(this.ckbMilitar);
            this.groupBox1.Controls.Add(this.ckbComercial);
            this.groupBox1.Controls.Add(this.ckbCivil);
            this.groupBox1.Location = new System.Drawing.Point(133, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 122);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ckbComercial
            // 
            this.ckbComercial.AutoSize = true;
            this.ckbComercial.Location = new System.Drawing.Point(7, 47);
            this.ckbComercial.Name = "ckbComercial";
            this.ckbComercial.Size = new System.Drawing.Size(90, 20);
            this.ckbComercial.TabIndex = 16;
            this.ckbComercial.Text = "Comercial";
            this.ckbComercial.UseVisualStyleBackColor = true;
            // 
            // ckbMilitar
            // 
            this.ckbMilitar.AutoSize = true;
            this.ckbMilitar.Location = new System.Drawing.Point(6, 73);
            this.ckbMilitar.Name = "ckbMilitar";
            this.ckbMilitar.Size = new System.Drawing.Size(64, 20);
            this.ckbMilitar.TabIndex = 17;
            this.ckbMilitar.Text = "Militar";
            this.ckbMilitar.UseVisualStyleBackColor = true;
            // 
            // cbkExperimental
            // 
            this.cbkExperimental.AutoSize = true;
            this.cbkExperimental.Location = new System.Drawing.Point(7, 99);
            this.cbkExperimental.Name = "cbkExperimental";
            this.cbkExperimental.Size = new System.Drawing.Size(107, 20);
            this.cbkExperimental.TabIndex = 18;
            this.cbkExperimental.Text = "Experimental";
            this.cbkExperimental.UseVisualStyleBackColor = true;
            // 
            // FormProductAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1452, 673);
            this.Controls.Add(btnBackMainMenu_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstProductPlane);
            this.Controls.Add(this.lblRefreshProductPlane);
            this.Controls.Add(this.lblTitluProductAvion);
            this.Controls.Add(this.lblSalvareProductPlane);
            this.Name = "FormProductAvion";
            this.Text = "FormProductAvion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitluProductAvion;
        private System.Windows.Forms.Label lblCompanie;
        private System.Windows.Forms.Label lblTaraOrigine;
        private System.Windows.Forms.Label lblAnInfiintare;
        private System.Windows.Forms.Label lblnrAngajati;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.ListBox lstProductPlane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCompanie;
        private System.Windows.Forms.TextBox txtNrAngajati;
        private System.Windows.Forms.TextBox txtAnInfiintare;
        private System.Windows.Forms.TextBox txtTaraOrigine;
        private System.Windows.Forms.Button btnRefreshProductPlane;
        private System.Windows.Forms.Button btnAdaugaProductPlane;
        private System.Windows.Forms.Label lblSalvareProductPlane;
        private System.Windows.Forms.Label lblRefreshProductPlane;
        private System.Windows.Forms.Button btnStergeProductPlane;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbCivil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbMilitar;
        private System.Windows.Forms.CheckBox ckbComercial;
        private System.Windows.Forms.CheckBox cbkExperimental;
    }
}