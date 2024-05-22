﻿using System.Drawing;

namespace Targ_Avioane_Interfata
{
    partial class Form1
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
            this.lbltitlu = new System.Windows.Forms.Label();
            this.txtIntroducereFirma = new System.Windows.Forms.TextBox();
            this.txtIntroducereModel = new System.Windows.Forms.TextBox();
            this.txtIntroducereAnFabricatie = new System.Windows.Forms.TextBox();
            this.txtIntroduceCuloare = new System.Windows.Forms.TextBox();
            this.txtIntroduceregreutate = new System.Windows.Forms.TextBox();
            this.txtIntroducepret = new System.Windows.Forms.TextBox();
            this.txtIntroducerenrpasg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbTipAvion = new System.Windows.Forms.GroupBox();
            this.rdbComercial = new System.Windows.Forms.RadioButton();
            this.rdbExperimental = new System.Windows.Forms.RadioButton();
            this.rdbMilitar = new System.Windows.Forms.RadioButton();
            this.rdbCivil = new System.Windows.Forms.RadioButton();
            this.pnllblAvion = new System.Windows.Forms.Panel();
            this.lblComponenteAvioane = new System.Windows.Forms.Label();
            this.lblPlaneType = new System.Windows.Forms.Label();
            this.lblIntroducerenrpasg = new System.Windows.Forms.Label();
            this.lblIntrodcducerepret = new System.Windows.Forms.Label();
            this.lblIntroducereGreutate = new System.Windows.Forms.Label();
            this.lblIntroducereCuloare = new System.Windows.Forms.Label();
            this.lblIntroducereAnfabricatie = new System.Windows.Forms.Label();
            this.lblIntroducereModel = new System.Windows.Forms.Label();
            this.lblIntroducereFirma = new System.Windows.Forms.Label();
            this.btnAdaugaAvioane = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBackMainMenu_2 = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPlane = new System.Windows.Forms.DataGridView();
            this.lblSalvarePlane = new System.Windows.Forms.Label();
            this.lblRefreshDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbTipAvion.SuspendLayout();
            this.pnllblAvion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitlu
            // 
            this.lbltitlu.AutoSize = true;
            this.lbltitlu.BackColor = System.Drawing.Color.Cyan;
            this.lbltitlu.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbltitlu.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbltitlu.Location = new System.Drawing.Point(445, 34);
            this.lbltitlu.Name = "lbltitlu";
            this.lbltitlu.Size = new System.Drawing.Size(122, 33);
            this.lbltitlu.TabIndex = 0;
            this.lbltitlu.Text = "Avioane";
            this.lbltitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIntroducereFirma
            // 
            this.txtIntroducereFirma.Location = new System.Drawing.Point(8, 15);
            this.txtIntroducereFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroducereFirma.Name = "txtIntroducereFirma";
            this.txtIntroducereFirma.Size = new System.Drawing.Size(177, 22);
            this.txtIntroducereFirma.TabIndex = 3;
            // 
            // txtIntroducereModel
            // 
            this.txtIntroducereModel.Location = new System.Drawing.Point(8, 48);
            this.txtIntroducereModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroducereModel.Name = "txtIntroducereModel";
            this.txtIntroducereModel.Size = new System.Drawing.Size(177, 22);
            this.txtIntroducereModel.TabIndex = 5;
            // 
            // txtIntroducereAnFabricatie
            // 
            this.txtIntroducereAnFabricatie.Location = new System.Drawing.Point(8, 86);
            this.txtIntroducereAnFabricatie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroducereAnFabricatie.Name = "txtIntroducereAnFabricatie";
            this.txtIntroducereAnFabricatie.Size = new System.Drawing.Size(177, 22);
            this.txtIntroducereAnFabricatie.TabIndex = 6;
            // 
            // txtIntroduceCuloare
            // 
            this.txtIntroduceCuloare.Location = new System.Drawing.Point(8, 123);
            this.txtIntroduceCuloare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroduceCuloare.Name = "txtIntroduceCuloare";
            this.txtIntroduceCuloare.Size = new System.Drawing.Size(177, 22);
            this.txtIntroduceCuloare.TabIndex = 7;
            // 
            // txtIntroduceregreutate
            // 
            this.txtIntroduceregreutate.Location = new System.Drawing.Point(8, 153);
            this.txtIntroduceregreutate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroduceregreutate.Name = "txtIntroduceregreutate";
            this.txtIntroduceregreutate.Size = new System.Drawing.Size(177, 22);
            this.txtIntroduceregreutate.TabIndex = 8;
            // 
            // txtIntroducepret
            // 
            this.txtIntroducepret.Location = new System.Drawing.Point(8, 188);
            this.txtIntroducepret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroducepret.Name = "txtIntroducepret";
            this.txtIntroducepret.Size = new System.Drawing.Size(177, 22);
            this.txtIntroducepret.TabIndex = 9;
            // 
            // txtIntroducerenrpasg
            // 
            this.txtIntroducerenrpasg.Location = new System.Drawing.Point(8, 228);
            this.txtIntroducerenrpasg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroducerenrpasg.Name = "txtIntroducerenrpasg";
            this.txtIntroducerenrpasg.Size = new System.Drawing.Size(177, 22);
            this.txtIntroducerenrpasg.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.gpbTipAvion);
            this.panel1.Controls.Add(this.txtIntroducerenrpasg);
            this.panel1.Controls.Add(this.txtIntroducepret);
            this.panel1.Controls.Add(this.txtIntroduceregreutate);
            this.panel1.Controls.Add(this.txtIntroduceCuloare);
            this.panel1.Controls.Add(this.txtIntroducereAnFabricatie);
            this.panel1.Controls.Add(this.txtIntroducereModel);
            this.panel1.Controls.Add(this.txtIntroducereFirma);
            this.panel1.Location = new System.Drawing.Point(1275, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 406);
            this.panel1.TabIndex = 11;
            // 
            // gpbTipAvion
            // 
            this.gpbTipAvion.Controls.Add(this.rdbComercial);
            this.gpbTipAvion.Controls.Add(this.rdbExperimental);
            this.gpbTipAvion.Controls.Add(this.rdbMilitar);
            this.gpbTipAvion.Controls.Add(this.rdbCivil);
            this.gpbTipAvion.Location = new System.Drawing.Point(10, 255);
            this.gpbTipAvion.Name = "gpbTipAvion";
            this.gpbTipAvion.Size = new System.Drawing.Size(275, 97);
            this.gpbTipAvion.TabIndex = 11;
            this.gpbTipAvion.TabStop = false;
            // 
            // rdbComercial
            // 
            this.rdbComercial.AutoSize = true;
            this.rdbComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbComercial.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdbComercial.Location = new System.Drawing.Point(6, 21);
            this.rdbComercial.Name = "rdbComercial";
            this.rdbComercial.Size = new System.Drawing.Size(106, 24);
            this.rdbComercial.TabIndex = 2;
            this.rdbComercial.TabStop = true;
            this.rdbComercial.Text = "Comercial";
            this.rdbComercial.UseVisualStyleBackColor = true;
            this.rdbComercial.CheckedChanged += new System.EventHandler(this.rdbComercial_CheckedChanged);
            // 
            // rdbExperimental
            // 
            this.rdbExperimental.AutoSize = true;
            this.rdbExperimental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbExperimental.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdbExperimental.Location = new System.Drawing.Point(125, 21);
            this.rdbExperimental.Name = "rdbExperimental";
            this.rdbExperimental.Size = new System.Drawing.Size(127, 24);
            this.rdbExperimental.TabIndex = 3;
            this.rdbExperimental.TabStop = true;
            this.rdbExperimental.Text = "Experimental";
            this.rdbExperimental.UseVisualStyleBackColor = true;
            // 
            // rdbMilitar
            // 
            this.rdbMilitar.AutoSize = true;
            this.rdbMilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbMilitar.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdbMilitar.Location = new System.Drawing.Point(125, 54);
            this.rdbMilitar.Name = "rdbMilitar";
            this.rdbMilitar.Size = new System.Drawing.Size(76, 24);
            this.rdbMilitar.TabIndex = 0;
            this.rdbMilitar.TabStop = true;
            this.rdbMilitar.Text = "Militar";
            this.rdbMilitar.UseVisualStyleBackColor = true;
            // 
            // rdbCivil
            // 
            this.rdbCivil.AutoSize = true;
            this.rdbCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbCivil.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdbCivil.Location = new System.Drawing.Point(6, 54);
            this.rdbCivil.Name = "rdbCivil";
            this.rdbCivil.Size = new System.Drawing.Size(62, 24);
            this.rdbCivil.TabIndex = 1;
            this.rdbCivil.TabStop = true;
            this.rdbCivil.Text = "Civil";
            this.rdbCivil.UseVisualStyleBackColor = true;
            // 
            // pnllblAvion
            // 
            this.pnllblAvion.BackColor = System.Drawing.Color.Azure;
            this.pnllblAvion.Controls.Add(this.lblComponenteAvioane);
            this.pnllblAvion.Controls.Add(this.lblPlaneType);
            this.pnllblAvion.Controls.Add(this.lblIntroducerenrpasg);
            this.pnllblAvion.Controls.Add(this.lblIntrodcducerepret);
            this.pnllblAvion.Controls.Add(this.lblIntroducereGreutate);
            this.pnllblAvion.Controls.Add(this.lblIntroducereCuloare);
            this.pnllblAvion.Controls.Add(this.lblIntroducereAnfabricatie);
            this.pnllblAvion.Controls.Add(this.lblIntroducereModel);
            this.pnllblAvion.Controls.Add(this.lblIntroducereFirma);
            this.pnllblAvion.Location = new System.Drawing.Point(1131, 28);
            this.pnllblAvion.Margin = new System.Windows.Forms.Padding(4);
            this.pnllblAvion.Name = "pnllblAvion";
            this.pnllblAvion.Size = new System.Drawing.Size(145, 406);
            this.pnllblAvion.TabIndex = 12;
            // 
            // lblComponenteAvioane
            // 
            this.lblComponenteAvioane.AutoSize = true;
            this.lblComponenteAvioane.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComponenteAvioane.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblComponenteAvioane.Location = new System.Drawing.Point(4, 344);
            this.lblComponenteAvioane.Name = "lblComponenteAvioane";
            this.lblComponenteAvioane.Size = new System.Drawing.Size(140, 48);
            this.lblComponenteAvioane.TabIndex = 16;
            this.lblComponenteAvioane.Text = "Componenete \r\nAvion:";
            this.lblComponenteAvioane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaneType
            // 
            this.lblPlaneType.AutoSize = true;
            this.lblPlaneType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlaneType.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPlaneType.Location = new System.Drawing.Point(20, 276);
            this.lblPlaneType.Name = "lblPlaneType";
            this.lblPlaneType.Size = new System.Drawing.Size(88, 48);
            this.lblPlaneType.TabIndex = 7;
            this.lblPlaneType.Text = "Tipul de \r\navion:";
            this.lblPlaneType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntroducerenrpasg
            // 
            this.lblIntroducerenrpasg.AutoSize = true;
            this.lblIntroducerenrpasg.BackColor = System.Drawing.Color.Azure;
            this.lblIntroducerenrpasg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroducerenrpasg.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntroducerenrpasg.Location = new System.Drawing.Point(16, 217);
            this.lblIntroducerenrpasg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroducerenrpasg.Name = "lblIntroducerenrpasg";
            this.lblIntroducerenrpasg.Size = new System.Drawing.Size(101, 46);
            this.lblIntroducerenrpasg.TabIndex = 6;
            this.lblIntroducerenrpasg.Text = "Număr de \r\npasgeri:";
            this.lblIntroducerenrpasg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntrodcducerepret
            // 
            this.lblIntrodcducerepret.AutoSize = true;
            this.lblIntrodcducerepret.BackColor = System.Drawing.Color.Azure;
            this.lblIntrodcducerepret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntrodcducerepret.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntrodcducerepret.Location = new System.Drawing.Point(52, 188);
            this.lblIntrodcducerepret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntrodcducerepret.Name = "lblIntrodcducerepret";
            this.lblIntrodcducerepret.Size = new System.Drawing.Size(50, 23);
            this.lblIntrodcducerepret.TabIndex = 5;
            this.lblIntrodcducerepret.Text = "Preț:";
            // 
            // lblIntroducereGreutate
            // 
            this.lblIntroducereGreutate.AutoSize = true;
            this.lblIntroducereGreutate.BackColor = System.Drawing.Color.Azure;
            this.lblIntroducereGreutate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroducereGreutate.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntroducereGreutate.Location = new System.Drawing.Point(27, 151);
            this.lblIntroducereGreutate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroducereGreutate.Name = "lblIntroducereGreutate";
            this.lblIntroducereGreutate.Size = new System.Drawing.Size(90, 23);
            this.lblIntroducereGreutate.TabIndex = 4;
            this.lblIntroducereGreutate.Text = "Greutate:";
            // 
            // lblIntroducereCuloare
            // 
            this.lblIntroducereCuloare.AutoSize = true;
            this.lblIntroducereCuloare.BackColor = System.Drawing.Color.Azure;
            this.lblIntroducereCuloare.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroducereCuloare.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntroducereCuloare.Location = new System.Drawing.Point(37, 122);
            this.lblIntroducereCuloare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroducereCuloare.Name = "lblIntroducereCuloare";
            this.lblIntroducereCuloare.Size = new System.Drawing.Size(84, 23);
            this.lblIntroducereCuloare.TabIndex = 3;
            this.lblIntroducereCuloare.Text = "Culoare:";
            // 
            // lblIntroducereAnfabricatie
            // 
            this.lblIntroducereAnfabricatie.AutoSize = true;
            this.lblIntroducereAnfabricatie.BackColor = System.Drawing.Color.Azure;
            this.lblIntroducereAnfabricatie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroducereAnfabricatie.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntroducereAnfabricatie.Location = new System.Drawing.Point(4, 84);
            this.lblIntroducereAnfabricatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroducereAnfabricatie.Name = "lblIntroducereAnfabricatie";
            this.lblIntroducereAnfabricatie.Size = new System.Drawing.Size(124, 23);
            this.lblIntroducereAnfabricatie.TabIndex = 2;
            this.lblIntroducereAnfabricatie.Text = "An fabricație:";
            // 
            // lblIntroducereModel
            // 
            this.lblIntroducereModel.AutoSize = true;
            this.lblIntroducereModel.BackColor = System.Drawing.Color.Azure;
            this.lblIntroducereModel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroducereModel.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntroducereModel.Location = new System.Drawing.Point(35, 46);
            this.lblIntroducereModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroducereModel.Name = "lblIntroducereModel";
            this.lblIntroducereModel.Size = new System.Drawing.Size(69, 23);
            this.lblIntroducereModel.TabIndex = 1;
            this.lblIntroducereModel.Text = "Model:";
            // 
            // lblIntroducereFirma
            // 
            this.lblIntroducereFirma.AutoSize = true;
            this.lblIntroducereFirma.BackColor = System.Drawing.Color.Azure;
            this.lblIntroducereFirma.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroducereFirma.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIntroducereFirma.Location = new System.Drawing.Point(37, 15);
            this.lblIntroducereFirma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroducereFirma.Name = "lblIntroducereFirma";
            this.lblIntroducereFirma.Size = new System.Drawing.Size(62, 22);
            this.lblIntroducereFirma.TabIndex = 0;
            this.lblIntroducereFirma.Text = "Firma:";
            // 
            // btnAdaugaAvioane
            // 
            this.btnAdaugaAvioane.BackColor = System.Drawing.Color.Moccasin;
            this.btnAdaugaAvioane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdaugaAvioane.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaAvioane.ForeColor = System.Drawing.Color.Chocolate;
            this.btnAdaugaAvioane.Location = new System.Drawing.Point(1093, 441);
            this.btnAdaugaAvioane.Name = "btnAdaugaAvioane";
            this.btnAdaugaAvioane.Size = new System.Drawing.Size(110, 36);
            this.btnAdaugaAvioane.TabIndex = 13;
            this.btnAdaugaAvioane.Text = "&Adaugă";
            this.btnAdaugaAvioane.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Moccasin;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Chocolate;
            this.btnRefresh.Location = new System.Drawing.Point(1093, 507);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnBackMainMenu_2
            // 
            this.btnBackMainMenu_2.BackColor = System.Drawing.Color.Moccasin;
            this.btnBackMainMenu_2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackMainMenu_2.ForeColor = System.Drawing.Color.Chocolate;
            this.btnBackMainMenu_2.Location = new System.Drawing.Point(1235, 552);
            this.btnBackMainMenu_2.Name = "btnBackMainMenu_2";
            this.btnBackMainMenu_2.Size = new System.Drawing.Size(188, 75);
            this.btnBackMainMenu_2.TabIndex = 15;
            this.btnBackMainMenu_2.Text = "Înapoi în meniul principal";
            this.btnBackMainMenu_2.UseVisualStyleBackColor = false;
            this.btnBackMainMenu_2.Click += new System.EventHandler(this.btnBackMainMenu_2_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.Moccasin;
            this.btnCauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCauta.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.Chocolate;
            this.btnCauta.Location = new System.Drawing.Point(1235, 441);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(110, 36);
            this.btnCauta.TabIndex = 16;
            this.btnCauta.Text = "&Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Moccasin;
            this.btnModifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModifica.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Chocolate;
            this.btnModifica.Location = new System.Drawing.Point(1235, 507);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(110, 36);
            this.btnModifica.TabIndex = 17;
            this.btnModifica.Text = "&Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(1387, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "&Șterge";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvPlane
            // 
            this.dgvPlane.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlane.Location = new System.Drawing.Point(23, 123);
            this.dgvPlane.Name = "dgvPlane";
            this.dgvPlane.RowHeadersWidth = 51;
            this.dgvPlane.RowTemplate.Height = 24;
            this.dgvPlane.Size = new System.Drawing.Size(1064, 483);
            this.dgvPlane.TabIndex = 19;
            // 
            // lblSalvarePlane
            // 
            this.lblSalvarePlane.AutoSize = true;
            this.lblSalvarePlane.BackColor = System.Drawing.Color.Azure;
            this.lblSalvarePlane.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSalvarePlane.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSalvarePlane.Location = new System.Drawing.Point(1115, 669);
            this.lblSalvarePlane.Name = "lblSalvarePlane";
            this.lblSalvarePlane.Size = new System.Drawing.Size(0, 24);
            this.lblSalvarePlane.TabIndex = 20;
            // 
            // lblRefreshDate
            // 
            this.lblRefreshDate.AutoSize = true;
            this.lblRefreshDate.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblRefreshDate.Location = new System.Drawing.Point(1148, 687);
            this.lblRefreshDate.Name = "lblRefreshDate";
            this.lblRefreshDate.Size = new System.Drawing.Size(0, 16);
            this.lblRefreshDate.TabIndex = 21;
            this.lblRefreshDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1782, 673);
            this.Controls.Add(this.lblRefreshDate);
            this.Controls.Add(this.lblSalvarePlane);
            this.Controls.Add(this.dgvPlane);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnBackMainMenu_2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdaugaAvioane);
            this.Controls.Add(this.pnllblAvion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitlu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BusinessPlaneUP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbTipAvion.ResumeLayout(false);
            this.gpbTipAvion.PerformLayout();
            this.pnllblAvion.ResumeLayout(false);
            this.pnllblAvion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitlu;
        private System.Windows.Forms.TextBox txtIntroducereFirma;
        private System.Windows.Forms.TextBox txtIntroducereModel;
        private System.Windows.Forms.TextBox txtIntroducereAnFabricatie;
        private System.Windows.Forms.TextBox txtIntroduceCuloare;
        private System.Windows.Forms.TextBox txtIntroduceregreutate;
        private System.Windows.Forms.TextBox txtIntroducepret;
        private System.Windows.Forms.TextBox txtIntroducerenrpasg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnllblAvion;
        private System.Windows.Forms.Label lblIntroducereModel;
        private System.Windows.Forms.Label lblIntroducereFirma;
        private System.Windows.Forms.Label lblIntroducereAnfabricatie;
        private System.Windows.Forms.Label lblIntroducereCuloare;
        private System.Windows.Forms.Label lblIntroducereGreutate;
        private System.Windows.Forms.Label lblIntrodcducerepret;
        private System.Windows.Forms.Label lblIntroducerenrpasg;
        private System.Windows.Forms.Button btnAdaugaAvioane;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBackMainMenu_2;
        private System.Windows.Forms.RadioButton rdbMilitar;
        private System.Windows.Forms.RadioButton rdbComercial;
        private System.Windows.Forms.RadioButton rdbCivil;
        private System.Windows.Forms.RadioButton rdbExperimental;
        private System.Windows.Forms.GroupBox gpbTipAvion;
        private System.Windows.Forms.Label lblPlaneType;
        private System.Windows.Forms.Label lblComponenteAvioane;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPlane;
        private System.Windows.Forms.Label lblSalvarePlane;
        private System.Windows.Forms.Label lblRefreshDate;
    }
}

