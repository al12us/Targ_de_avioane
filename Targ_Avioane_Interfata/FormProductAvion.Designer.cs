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
            this.lblTitluProductAvion = new System.Windows.Forms.Label();
            this.lblCompanie = new System.Windows.Forms.Label();
            this.lblTaraOrigine = new System.Windows.Forms.Label();
            this.lblAnInfiintare = new System.Windows.Forms.Label();
            this.lblnrAngajati = new System.Windows.Forms.Label();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitluProductAvion
            // 
            this.lblTitluProductAvion.AutoSize = true;
            this.lblTitluProductAvion.BackColor = System.Drawing.Color.Yellow;
            this.lblTitluProductAvion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitluProductAvion.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblTitluProductAvion.Location = new System.Drawing.Point(158, 60);
            this.lblTitluProductAvion.Name = "lblTitluProductAvion";
            this.lblTitluProductAvion.Size = new System.Drawing.Size(263, 27);
            this.lblTitluProductAvion.TabIndex = 0;
            this.lblTitluProductAvion.Text = "Producător de avioane";
            this.lblTitluProductAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitluProductAvion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCompanie
            // 
            this.lblCompanie.AutoSize = true;
            this.lblCompanie.Location = new System.Drawing.Point(33, 126);
            this.lblCompanie.Name = "lblCompanie";
            this.lblCompanie.Size = new System.Drawing.Size(69, 16);
            this.lblCompanie.TabIndex = 1;
            this.lblCompanie.Text = "Companie";
            this.lblCompanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaraOrigine
            // 
            this.lblTaraOrigine.AutoSize = true;
            this.lblTaraOrigine.Location = new System.Drawing.Point(132, 126);
            this.lblTaraOrigine.Name = "lblTaraOrigine";
            this.lblTaraOrigine.Size = new System.Drawing.Size(101, 16);
            this.lblTaraOrigine.TabIndex = 2;
            this.lblTaraOrigine.Text = "Țara de Origine";
            // 
            // lblAnInfiintare
            // 
            this.lblAnInfiintare.AutoSize = true;
            this.lblAnInfiintare.Location = new System.Drawing.Point(270, 126);
            this.lblAnInfiintare.Name = "lblAnInfiintare";
            this.lblAnInfiintare.Size = new System.Drawing.Size(33, 16);
            this.lblAnInfiintare.TabIndex = 3;
            this.lblAnInfiintare.Text = "Anul";
            this.lblAnInfiintare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnInfiintare.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblnrAngajati
            // 
            this.lblnrAngajati.AutoSize = true;
            this.lblnrAngajati.Location = new System.Drawing.Point(326, 126);
            this.lblnrAngajati.Name = "lblnrAngajati";
            this.lblnrAngajati.Size = new System.Drawing.Size(69, 32);
            this.lblnrAngajati.TabIndex = 4;
            this.lblnrAngajati.Text = "Număr de \r\nangajați";
            this.lblnrAngajati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(419, 126);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(82, 16);
            this.lblSpecializare.TabIndex = 5;
            this.lblSpecializare.Text = "Specializare";
            // 
            // FormProductAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.lblnrAngajati);
            this.Controls.Add(this.lblAnInfiintare);
            this.Controls.Add(this.lblTaraOrigine);
            this.Controls.Add(this.lblCompanie);
            this.Controls.Add(this.lblTitluProductAvion);
            this.Name = "FormProductAvion";
            this.Text = "FormProductAvion";
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
    }
}