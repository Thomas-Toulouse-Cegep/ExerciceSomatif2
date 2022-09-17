namespace ExerciceSomatif2
{
    partial class FormAffichageForme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenererForme = new System.Windows.Forms.Button();
            this.controlUserForme1 = new ExerciceSomatif2.Controles.ControlUserForme();
            this.SuspendLayout();
            // 
            // btnGenererForme
            // 
            this.btnGenererForme.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenererForme.Location = new System.Drawing.Point(276, 385);
            this.btnGenererForme.Name = "btnGenererForme";
            this.btnGenererForme.Size = new System.Drawing.Size(223, 53);
            this.btnGenererForme.TabIndex = 0;
            this.btnGenererForme.Text = "Générer Forme";
            this.btnGenererForme.UseVisualStyleBackColor = true;
            this.btnGenererForme.Click += new System.EventHandler(this.btnGenererForme_Click);
            // 
            // controlUserForme1
            // 
            this.controlUserForme1.Forme = null;
            this.controlUserForme1.Location = new System.Drawing.Point(12, 12);
            this.controlUserForme1.Name = "controlUserForme1";
            this.controlUserForme1.Size = new System.Drawing.Size(776, 338);
            this.controlUserForme1.TabIndex = 1;
            // 
            // FormAffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlUserForme1);
            this.Controls.Add(this.btnGenererForme);
            this.Name = "FormAffichageForme";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGenererForme;
        private Controles.ControlUserForme controlUserForme1;
    }
}