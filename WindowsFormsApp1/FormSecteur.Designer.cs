namespace WindowsFormsApp1
{
    partial class lbl
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
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.tbxNomSecteur = new System.Windows.Forms.TextBox();
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Location = new System.Drawing.Point(119, 89);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterSecteur.TabIndex = 0;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            // 
            // tbxNomSecteur
            // 
            this.tbxNomSecteur.Location = new System.Drawing.Point(109, 63);
            this.tbxNomSecteur.Name = "tbxNomSecteur";
            this.tbxNomSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxNomSecteur.TabIndex = 1;
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(30, 66);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(73, 13);
            this.lblNomSecteur.TabIndex = 3;
            this.lblNomSecteur.Text = "Nom secteur :";
            this.lblNomSecteur.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomSecteur);
            this.Controls.Add(this.tbxNomSecteur);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Name = "lbl";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.TextBox tbxNomSecteur;
        private System.Windows.Forms.Label lblNomSecteur;
    }
}