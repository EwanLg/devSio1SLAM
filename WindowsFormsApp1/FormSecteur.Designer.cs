﻿namespace WindowsFormsApp1
{
    partial class FormSecteur
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
            this.SuspendLayout();
            // 
            // FormSecteur
            // 
            this.ClientSize = new System.Drawing.Size(784, 397);
            this.Name = "FormSecteur";
            this.Load += new System.EventHandler(this.FormSecteur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.TextBox tbxNomSecteur;
        private System.Windows.Forms.Label lblNomSecteur;
    }
}