﻿namespace BDO_Bahar_FinalProjesi
{
    partial class kasSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasSistemi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKafa = new System.Windows.Forms.Button();
            this.btnKol = new System.Windows.Forms.Button();
            this.btnGovde = new System.Windows.Forms.Button();
            this.btnBacak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(317, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 475);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnKafa
            // 
            this.btnKafa.Location = new System.Drawing.Point(614, 79);
            this.btnKafa.Name = "btnKafa";
            this.btnKafa.Size = new System.Drawing.Size(85, 35);
            this.btnKafa.TabIndex = 2;
            this.btnKafa.Text = "Kafa";
            this.btnKafa.UseVisualStyleBackColor = true;
            // 
            // btnKol
            // 
            this.btnKol.Location = new System.Drawing.Point(226, 185);
            this.btnKol.Name = "btnKol";
            this.btnKol.Size = new System.Drawing.Size(85, 35);
            this.btnKol.TabIndex = 3;
            this.btnKol.Text = "Kol";
            this.btnKol.UseVisualStyleBackColor = true;
            // 
            // btnGovde
            // 
            this.btnGovde.Location = new System.Drawing.Point(614, 250);
            this.btnGovde.Name = "btnGovde";
            this.btnGovde.Size = new System.Drawing.Size(85, 35);
            this.btnGovde.TabIndex = 4;
            this.btnGovde.Text = "Gövde";
            this.btnGovde.UseVisualStyleBackColor = true;
            // 
            // btnBacak
            // 
            this.btnBacak.Location = new System.Drawing.Point(226, 400);
            this.btnBacak.Name = "btnBacak";
            this.btnBacak.Size = new System.Drawing.Size(85, 35);
            this.btnBacak.TabIndex = 5;
            this.btnBacak.Text = "Bacak";
            this.btnBacak.UseVisualStyleBackColor = true;
            // 
            // kasSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 618);
            this.Controls.Add(this.btnBacak);
            this.Controls.Add(this.btnGovde);
            this.Controls.Add(this.btnKol);
            this.Controls.Add(this.btnKafa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kasSistemi";
            this.Text = "kasSistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKafa;
        private System.Windows.Forms.Button btnKol;
        private System.Windows.Forms.Button btnGovde;
        private System.Windows.Forms.Button btnBacak;
    }
}