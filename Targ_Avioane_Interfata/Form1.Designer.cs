using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitlu = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAnFabricatie = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtGreutate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtNrPasg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbComponente = new System.Windows.Forms.GroupBox();
            this.ckbAdaptare = new System.Windows.Forms.CheckBox();
            this.ckbAprovizionare = new System.Windows.Forms.CheckBox();
            this.ckbSigurantaSupraveghere = new System.Windows.Forms.CheckBox();
            this.ckbSistemDeContramasuri = new System.Windows.Forms.CheckBox();
            this.ckbSistemedeArmament = new System.Windows.Forms.CheckBox();
            this.ckbControlAutomatizare = new System.Windows.Forms.CheckBox();
            this.ckbComunicare = new System.Windows.Forms.CheckBox();
            this.ckbNavigare = new System.Windows.Forms.CheckBox();
            this.ckbPropulsie = new System.Windows.Forms.CheckBox();
            this.ckbAeroframe = new System.Windows.Forms.CheckBox();
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
            this.dgvPlane = new System.Windows.Forms.DataGridView();
            this.lblSalvarePlane = new System.Windows.Forms.Label();
            this.lblRefreshDate = new System.Windows.Forms.Label();
            this.lblValidare = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpbComponente.SuspendLayout();
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
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(8, 15);
            this.txtFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(177, 22);
            this.txtFirma.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(8, 48);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(177, 22);
            this.txtModel.TabIndex = 5;
            // 
            // txtAnFabricatie
            // 
            this.txtAnFabricatie.Location = new System.Drawing.Point(8, 86);
            this.txtAnFabricatie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnFabricatie.Name = "txtAnFabricatie";
            this.txtAnFabricatie.Size = new System.Drawing.Size(177, 22);
            this.txtAnFabricatie.TabIndex = 6;
            // 
            // txtCuloare
            // 
            this.txtCuloare.Location = new System.Drawing.Point(8, 123);
            this.txtCuloare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(177, 22);
            this.txtCuloare.TabIndex = 7;
            // 
            // txtGreutate
            // 
            this.txtGreutate.Location = new System.Drawing.Point(8, 153);
            this.txtGreutate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGreutate.Name = "txtGreutate";
            this.txtGreutate.Size = new System.Drawing.Size(177, 22);
            this.txtGreutate.TabIndex = 8;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(8, 188);
            this.txtPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(177, 22);
            this.txtPret.TabIndex = 9;
            // 
            // txtNrPasg
            // 
            this.txtNrPasg.Location = new System.Drawing.Point(8, 228);
            this.txtNrPasg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrPasg.Name = "txtNrPasg";
            this.txtNrPasg.Size = new System.Drawing.Size(177, 22);
            this.txtNrPasg.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.gpbComponente);
            this.panel1.Controls.Add(this.gpbTipAvion);
            this.panel1.Controls.Add(this.txtNrPasg);
            this.panel1.Controls.Add(this.txtPret);
            this.panel1.Controls.Add(this.txtGreutate);
            this.panel1.Controls.Add(this.txtCuloare);
            this.panel1.Controls.Add(this.txtAnFabricatie);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.txtFirma);
            this.panel1.Location = new System.Drawing.Point(1268, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 568);
            this.panel1.TabIndex = 11;
            // 
            // gpbComponente
            // 
            this.gpbComponente.Controls.Add(this.ckbAdaptare);
            this.gpbComponente.Controls.Add(this.ckbAprovizionare);
            this.gpbComponente.Controls.Add(this.ckbSigurantaSupraveghere);
            this.gpbComponente.Controls.Add(this.ckbSistemDeContramasuri);
            this.gpbComponente.Controls.Add(this.ckbSistemedeArmament);
            this.gpbComponente.Controls.Add(this.ckbControlAutomatizare);
            this.gpbComponente.Controls.Add(this.ckbComunicare);
            this.gpbComponente.Controls.Add(this.ckbNavigare);
            this.gpbComponente.Controls.Add(this.ckbPropulsie);
            this.gpbComponente.Controls.Add(this.ckbAeroframe);
            this.gpbComponente.Location = new System.Drawing.Point(17, 358);
            this.gpbComponente.Name = "gpbComponente";
            this.gpbComponente.Size = new System.Drawing.Size(458, 207);
            this.gpbComponente.TabIndex = 13;
            this.gpbComponente.TabStop = false;
            // 
            // ckbAdaptare
            // 
            this.ckbAdaptare.AutoSize = true;
            this.ckbAdaptare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic);
            this.ckbAdaptare.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbAdaptare.Location = new System.Drawing.Point(233, 166);
            this.ckbAdaptare.Name = "ckbAdaptare";
            this.ckbAdaptare.Size = new System.Drawing.Size(185, 44);
            this.ckbAdaptare.TabIndex = 21;
            this.ckbAdaptare.Text = "Sisteme de adaptare\r\n și modificare";
            this.ckbAdaptare.UseVisualStyleBackColor = true;
            this.ckbAdaptare.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbAprovizionare
            // 
            this.ckbAprovizionare.AutoSize = true;
            this.ckbAprovizionare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic);
            this.ckbAprovizionare.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbAprovizionare.Location = new System.Drawing.Point(233, 122);
            this.ckbAprovizionare.Name = "ckbAprovizionare";
            this.ckbAprovizionare.Size = new System.Drawing.Size(184, 44);
            this.ckbAprovizionare.TabIndex = 20;
            this.ckbAprovizionare.Text = "Sisteme de catering \r\nsi aprovizionare";
            this.ckbAprovizionare.UseVisualStyleBackColor = true;
            this.ckbAprovizionare.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbSigurantaSupraveghere
            // 
            this.ckbSigurantaSupraveghere.AutoSize = true;
            this.ckbSigurantaSupraveghere.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbSigurantaSupraveghere.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbSigurantaSupraveghere.Location = new System.Drawing.Point(233, 81);
            this.ckbSigurantaSupraveghere.Name = "ckbSigurantaSupraveghere";
            this.ckbSigurantaSupraveghere.Size = new System.Drawing.Size(188, 44);
            this.ckbSigurantaSupraveghere.TabIndex = 19;
            this.ckbSigurantaSupraveghere.Text = "Sisteme de siguranță\r\n și supraveghere";
            this.ckbSigurantaSupraveghere.UseVisualStyleBackColor = true;
            this.ckbSigurantaSupraveghere.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbSistemDeContramasuri
            // 
            this.ckbSistemDeContramasuri.AutoSize = true;
            this.ckbSistemDeContramasuri.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbSistemDeContramasuri.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbSistemDeContramasuri.Location = new System.Drawing.Point(233, 51);
            this.ckbSistemDeContramasuri.Name = "ckbSistemDeContramasuri";
            this.ckbSistemDeContramasuri.Size = new System.Drawing.Size(218, 24);
            this.ckbSistemDeContramasuri.TabIndex = 18;
            this.ckbSistemDeContramasuri.Text = "Sisteme de contramasuri";
            this.ckbSistemDeContramasuri.UseVisualStyleBackColor = true;
            this.ckbSistemDeContramasuri.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbSistemedeArmament
            // 
            this.ckbSistemedeArmament.AutoSize = true;
            this.ckbSistemedeArmament.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbSistemedeArmament.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbSistemedeArmament.Location = new System.Drawing.Point(233, 21);
            this.ckbSistemedeArmament.Name = "ckbSistemedeArmament";
            this.ckbSistemedeArmament.Size = new System.Drawing.Size(195, 24);
            this.ckbSistemedeArmament.TabIndex = 17;
            this.ckbSistemedeArmament.Text = "Sisteme de armament";
            this.ckbSistemedeArmament.UseVisualStyleBackColor = true;
            this.ckbSistemedeArmament.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbControlAutomatizare
            // 
            this.ckbControlAutomatizare.AutoSize = true;
            this.ckbControlAutomatizare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbControlAutomatizare.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbControlAutomatizare.Location = new System.Drawing.Point(10, 134);
            this.ckbControlAutomatizare.Name = "ckbControlAutomatizare";
            this.ckbControlAutomatizare.Size = new System.Drawing.Size(175, 44);
            this.ckbControlAutomatizare.TabIndex = 16;
            this.ckbControlAutomatizare.Text = "Sisteme de contol  \r\nsi automatizare";
            this.ckbControlAutomatizare.UseVisualStyleBackColor = true;
            this.ckbControlAutomatizare.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbComunicare
            // 
            this.ckbComunicare.AutoSize = true;
            this.ckbComunicare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbComunicare.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbComunicare.Location = new System.Drawing.Point(10, 108);
            this.ckbComunicare.Name = "ckbComunicare";
            this.ckbComunicare.Size = new System.Drawing.Size(201, 24);
            this.ckbComunicare.TabIndex = 15;
            this.ckbComunicare.Text = "Sistem de Comunicare";
            this.ckbComunicare.UseVisualStyleBackColor = true;
            this.ckbComunicare.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbNavigare
            // 
            this.ckbNavigare.AutoSize = true;
            this.ckbNavigare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbNavigare.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbNavigare.Location = new System.Drawing.Point(10, 82);
            this.ckbNavigare.Name = "ckbNavigare";
            this.ckbNavigare.Size = new System.Drawing.Size(182, 24);
            this.ckbNavigare.TabIndex = 14;
            this.ckbNavigare.Text = "Sisteme de navigare";
            this.ckbNavigare.UseVisualStyleBackColor = true;
            this.ckbNavigare.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbPropulsie
            // 
            this.ckbPropulsie.AutoSize = true;
            this.ckbPropulsie.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbPropulsie.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbPropulsie.Location = new System.Drawing.Point(10, 56);
            this.ckbPropulsie.Name = "ckbPropulsie";
            this.ckbPropulsie.Size = new System.Drawing.Size(188, 24);
            this.ckbPropulsie.TabIndex = 13;
            this.ckbPropulsie.Text = "Sisteme de propulsie";
            this.ckbPropulsie.UseVisualStyleBackColor = true;
            this.ckbPropulsie.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
            // 
            // ckbAeroframe
            // 
            this.ckbAeroframe.AutoSize = true;
            this.ckbAeroframe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbAeroframe.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbAeroframe.Location = new System.Drawing.Point(10, 30);
            this.ckbAeroframe.Name = "ckbAeroframe";
            this.ckbAeroframe.Size = new System.Drawing.Size(109, 24);
            this.ckbAeroframe.TabIndex = 12;
            this.ckbAeroframe.Text = "Aeroframe";
            this.ckbAeroframe.UseVisualStyleBackColor = true;
            this.ckbAeroframe.CheckedChanged += new System.EventHandler(this.CkbComponente_CheckedChanged);
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
            this.pnllblAvion.Location = new System.Drawing.Point(1130, 28);
            this.pnllblAvion.Margin = new System.Windows.Forms.Padding(4);
            this.pnllblAvion.Name = "pnllblAvion";
            this.pnllblAvion.Size = new System.Drawing.Size(145, 568);
            this.pnllblAvion.TabIndex = 12;
            // 
            // lblComponenteAvioane
            // 
            this.lblComponenteAvioane.AutoSize = true;
            this.lblComponenteAvioane.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComponenteAvioane.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblComponenteAvioane.Location = new System.Drawing.Point(2, 386);
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
            this.btnAdaugaAvioane.Location = new System.Drawing.Point(1148, 612);
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
            this.btnRefresh.Location = new System.Drawing.Point(1149, 669);
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
            this.btnBackMainMenu_2.Location = new System.Drawing.Point(1291, 714);
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
            this.btnCauta.Location = new System.Drawing.Point(1291, 612);
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
            this.btnModifica.Location = new System.Drawing.Point(1291, 669);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(110, 36);
            this.btnModifica.TabIndex = 17;
            this.btnModifica.Text = "&Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // dgvPlane
            // 
            this.dgvPlane.BackgroundColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlane.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlane.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlane.GridColor = System.Drawing.Color.Azure;
            this.dgvPlane.Location = new System.Drawing.Point(23, 123);
            this.dgvPlane.Name = "dgvPlane";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlane.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlane.RowHeadersWidth = 51;
            this.dgvPlane.RowTemplate.Height = 24;
            this.dgvPlane.Size = new System.Drawing.Size(1064, 483);
            this.dgvPlane.TabIndex = 19;
            this.dgvPlane.SelectionChanged += new System.EventHandler(this.dgvPlane_SelectionChanged);
            // 
            // lblSalvarePlane
            // 
            this.lblSalvarePlane.AutoSize = true;
            this.lblSalvarePlane.BackColor = System.Drawing.Color.Azure;
            this.lblSalvarePlane.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSalvarePlane.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSalvarePlane.Location = new System.Drawing.Point(1287, 824);
            this.lblSalvarePlane.Name = "lblSalvarePlane";
            this.lblSalvarePlane.Size = new System.Drawing.Size(0, 22);
            this.lblSalvarePlane.TabIndex = 20;
            // 
            // lblRefreshDate
            // 
            this.lblRefreshDate.AutoSize = true;
            this.lblRefreshDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRefreshDate.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblRefreshDate.Location = new System.Drawing.Point(1299, 889);
            this.lblRefreshDate.Name = "lblRefreshDate";
            this.lblRefreshDate.Size = new System.Drawing.Size(0, 20);
            this.lblRefreshDate.TabIndex = 21;
            this.lblRefreshDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValidare
            // 
            this.lblValidare.AutoSize = true;
            this.lblValidare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidare.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblValidare.Location = new System.Drawing.Point(40, 635);
            this.lblValidare.Name = "lblValidare";
            this.lblValidare.Size = new System.Drawing.Size(0, 20);
            this.lblValidare.TabIndex = 22;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Chocolate;
            this.btnReset.Location = new System.Drawing.Point(1431, 612);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 36);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.Moccasin;
            this.btnSterge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSterge.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSterge.Location = new System.Drawing.Point(1431, 669);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(110, 36);
            this.btnSterge.TabIndex = 24;
            this.btnSterge.Text = "&Șterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.Moccasin;
            this.btnActualizare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizare.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.ForeColor = System.Drawing.Color.Chocolate;
            this.btnActualizare.Location = new System.Drawing.Point(1576, 635);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(130, 43);
            this.btnActualizare.TabIndex = 25;
            this.btnActualizare.Text = "&Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1782, 953);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblValidare);
            this.Controls.Add(this.lblRefreshDate);
            this.Controls.Add(this.lblSalvarePlane);
            this.Controls.Add(this.dgvPlane);
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
            this.gpbComponente.ResumeLayout(false);
            this.gpbComponente.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtAnFabricatie;
        private System.Windows.Forms.TextBox txtCuloare;
        private System.Windows.Forms.TextBox txtGreutate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtNrPasg;
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
        private System.Windows.Forms.DataGridView dgvPlane;
        private System.Windows.Forms.Label lblSalvarePlane;
        private System.Windows.Forms.Label lblRefreshDate;
        private System.Windows.Forms.GroupBox gpbComponente;
        private System.Windows.Forms.CheckBox ckbNavigare;
        private System.Windows.Forms.CheckBox ckbPropulsie;
        private System.Windows.Forms.CheckBox ckbAeroframe;
        private System.Windows.Forms.CheckBox ckbComunicare;
        private System.Windows.Forms.CheckBox ckbSistemDeContramasuri;
        private System.Windows.Forms.CheckBox ckbSistemedeArmament;
        private System.Windows.Forms.CheckBox ckbControlAutomatizare;
        private System.Windows.Forms.CheckBox ckbSigurantaSupraveghere;
        private System.Windows.Forms.Label lblValidare;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.CheckBox ckbAdaptare;
        private System.Windows.Forms.CheckBox ckbAprovizionare;
        private System.Windows.Forms.Button btnActualizare;
    }
}

