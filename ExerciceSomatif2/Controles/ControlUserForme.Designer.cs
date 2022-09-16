namespace ExerciceSomatif2.Controles
{
    partial class ControlUserForme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTypeDeForme = new System.Windows.Forms.Label();
            this.lbAffichageForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTypeDeForme
            // 
            this.lbTypeDeForme.AutoSize = true;
            this.lbTypeDeForme.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTypeDeForme.Location = new System.Drawing.Point(0, 0);
            this.lbTypeDeForme.Name = "lbTypeDeForme";
            this.lbTypeDeForme.Size = new System.Drawing.Size(207, 38);
            this.lbTypeDeForme.TabIndex = 0;
            this.lbTypeDeForme.Text = "Type de Forme:";
            // 
            // lbAffichageForm
            // 
            this.lbAffichageForm.AutoSize = true;
            this.lbAffichageForm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAffichageForm.Location = new System.Drawing.Point(202, 0);
            this.lbAffichageForm.Name = "lbAffichageForm";
            this.lbAffichageForm.Size = new System.Drawing.Size(320, 38);
            this.lbAffichageForm.TabIndex = 1;
            this.lbAffichageForm.Text = "affichageType de Forme:";
            this.lbAffichageForm.Click += new System.EventHandler(this.lbAffichageForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(174, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 207);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ControlUserForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbAffichageForm);
            this.Controls.Add(this.lbTypeDeForme);
            this.Name = "ControlUserForme";
            this.Size = new System.Drawing.Size(563, 270);
            this.Load += new System.EventHandler(this.ControlUserForme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTypeDeForme;
        private Label lbAffichageForm;
        private PictureBox pictureBox1;
    }
}
