namespace Targ_Avioane_Interfata
{
    partial class MainMenuPlane
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
            this.btnAvioaneClass = new System.Windows.Forms.Button();
            this.btnProducatorAvioane = new System.Windows.Forms.Button();
            this.lblMenuMaintitle = new System.Windows.Forms.Label();
            this.pnlMaiMenu = new System.Windows.Forms.Panel();
            this.pnlMaiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvioaneClass
            // 
            this.btnAvioaneClass.BackColor = System.Drawing.Color.LightCyan;
            this.btnAvioaneClass.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnAvioaneClass.FlatAppearance.BorderSize = 5;
            this.btnAvioaneClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvioaneClass.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvioaneClass.ForeColor = System.Drawing.Color.Chocolate;
            this.btnAvioaneClass.Location = new System.Drawing.Point(51, 31);
            this.btnAvioaneClass.Name = "btnAvioaneClass";
            this.btnAvioaneClass.Padding = new System.Windows.Forms.Padding(4);
            this.btnAvioaneClass.Size = new System.Drawing.Size(200, 200);
            this.btnAvioaneClass.TabIndex = 0;
            this.btnAvioaneClass.Text = "&Avioane";
            this.btnAvioaneClass.UseVisualStyleBackColor = false;
            this.btnAvioaneClass.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProducatorAvioane
            // 
            this.btnProducatorAvioane.BackColor = System.Drawing.Color.LightCyan;
            this.btnProducatorAvioane.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnProducatorAvioane.FlatAppearance.BorderSize = 4;
            this.btnProducatorAvioane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducatorAvioane.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProducatorAvioane.ForeColor = System.Drawing.Color.Chocolate;
            this.btnProducatorAvioane.Location = new System.Drawing.Point(334, 29);
            this.btnProducatorAvioane.Name = "btnProducatorAvioane";
            this.btnProducatorAvioane.Size = new System.Drawing.Size(200, 200);
            this.btnProducatorAvioane.TabIndex = 1;
            this.btnProducatorAvioane.Text = "&Producătorul de avioane";
            this.btnProducatorAvioane.UseVisualStyleBackColor = false;
            this.btnProducatorAvioane.Click += new System.EventHandler(this.btnProducatorAvioane_Click);
            // 
            // lblMenuMaintitle
            // 
            this.lblMenuMaintitle.AutoSize = true;
            this.lblMenuMaintitle.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenuMaintitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lblMenuMaintitle.Location = new System.Drawing.Point(91, 47);
            this.lblMenuMaintitle.Name = "lblMenuMaintitle";
            this.lblMenuMaintitle.Size = new System.Drawing.Size(618, 42);
            this.lblMenuMaintitle.TabIndex = 2;
            this.lblMenuMaintitle.Text = "Târg de Avioane-aplicație";
            // 
            // pnlMaiMenu
            // 
            this.pnlMaiMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlMaiMenu.Controls.Add(this.btnProducatorAvioane);
            this.pnlMaiMenu.Controls.Add(this.btnAvioaneClass);
            this.pnlMaiMenu.Location = new System.Drawing.Point(83, 112);
            this.pnlMaiMenu.Name = "pnlMaiMenu";
            this.pnlMaiMenu.Size = new System.Drawing.Size(599, 279);
            this.pnlMaiMenu.TabIndex = 3;
            // 
            // MainMenuPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMaiMenu);
            this.Controls.Add(this.lblMenuMaintitle);
            this.Name = "MainMenuPlane";
            this.Text = "MainMenuPlane";
            this.pnlMaiMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvioaneClass;
        private System.Windows.Forms.Button btnProducatorAvioane;
        private System.Windows.Forms.Label lblMenuMaintitle;
        private System.Windows.Forms.Panel pnlMaiMenu;
    }
}