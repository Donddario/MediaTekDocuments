﻿namespace MediaTekDocuments.view
{
    partial class FrmModifierDvD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_parcourir = new System.Windows.Forms.Button();
            this.label59 = new System.Windows.Forms.Label();
            this.cb_rayon = new System.Windows.Forms.ComboBox();
            this.pcbLivresImage = new System.Windows.Forms.PictureBox();
            this.cb_public = new System.Windows.Forms.ComboBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.btn_modifierDvD = new System.Windows.Forms.Button();
            this.txbDuree = new System.Windows.Forms.TextBox();
            this.txbDvdImage = new System.Windows.Forms.TextBox();
            this.txbSynopsis = new System.Windows.Forms.TextBox();
            this.txbRealisateur = new System.Windows.Forms.TextBox();
            this.txbDvdTitre = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.btn_parcourir);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.cb_rayon);
            this.groupBox1.Controls.Add(this.pcbLivresImage);
            this.groupBox1.Controls.Add(this.cb_public);
            this.groupBox1.Controls.Add(this.cb_genre);
            this.groupBox1.Controls.Add(this.btn_modifierDvD);
            this.groupBox1.Controls.Add(this.txbDuree);
            this.groupBox1.Controls.Add(this.txbDvdImage);
            this.groupBox1.Controls.Add(this.txbSynopsis);
            this.groupBox1.Controls.Add(this.txbRealisateur);
            this.groupBox1.Controls.Add(this.txbDvdTitre);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier un DvD";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(150, 25);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 57;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(6, 28);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(135, 13);
            this.lbl_id.TabIndex = 56;
            this.lbl_id.Text = "Numéro du document :";
            // 
            // btn_parcourir
            // 
            this.btn_parcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parcourir.Location = new System.Drawing.Point(445, 235);
            this.btn_parcourir.Name = "btn_parcourir";
            this.btn_parcourir.Size = new System.Drawing.Size(96, 22);
            this.btn_parcourir.TabIndex = 55;
            this.btn_parcourir.Text = "Parcourir";
            this.btn_parcourir.UseVisualStyleBackColor = true;
            this.btn_parcourir.Click += new System.EventHandler(this.btn_parcourir_Click);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(560, 20);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(49, 13);
            this.label59.TabIndex = 35;
            this.label59.Text = "Image :";
            // 
            // cb_rayon
            // 
            this.cb_rayon.FormattingEnabled = true;
            this.cb_rayon.Location = new System.Drawing.Point(150, 208);
            this.cb_rayon.Name = "cb_rayon";
            this.cb_rayon.Size = new System.Drawing.Size(207, 21);
            this.cb_rayon.TabIndex = 54;
            // 
            // pcbLivresImage
            // 
            this.pcbLivresImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLivresImage.Location = new System.Drawing.Point(563, 36);
            this.pcbLivresImage.Name = "pcbLivresImage";
            this.pcbLivresImage.Size = new System.Drawing.Size(284, 213);
            this.pcbLivresImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLivresImage.TabIndex = 34;
            this.pcbLivresImage.TabStop = false;
            // 
            // cb_public
            // 
            this.cb_public.FormattingEnabled = true;
            this.cb_public.Location = new System.Drawing.Point(150, 183);
            this.cb_public.Name = "cb_public";
            this.cb_public.Size = new System.Drawing.Size(207, 21);
            this.cb_public.TabIndex = 53;
            // 
            // cb_genre
            // 
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Location = new System.Drawing.Point(150, 159);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(207, 21);
            this.cb_genre.TabIndex = 52;
            // 
            // btn_modifierDvD
            // 
            this.btn_modifierDvD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifierDvD.Location = new System.Drawing.Point(9, 266);
            this.btn_modifierDvD.Name = "btn_modifierDvD";
            this.btn_modifierDvD.Size = new System.Drawing.Size(96, 22);
            this.btn_modifierDvD.TabIndex = 51;
            this.btn_modifierDvD.Text = "Modifier";
            this.btn_modifierDvD.UseVisualStyleBackColor = true;
            this.btn_modifierDvD.Click += new System.EventHandler(this.btn_modifierDvD_Click);
            // 
            // txbDuree
            // 
            this.txbDuree.Location = new System.Drawing.Point(441, 25);
            this.txbDuree.Name = "txbDuree";
            this.txbDuree.Size = new System.Drawing.Size(100, 20);
            this.txbDuree.TabIndex = 50;
            // 
            // txbDvdImage
            // 
            this.txbDvdImage.Location = new System.Drawing.Point(150, 237);
            this.txbDvdImage.Name = "txbDvdImage";
            this.txbDvdImage.ReadOnly = true;
            this.txbDvdImage.Size = new System.Drawing.Size(284, 20);
            this.txbDvdImage.TabIndex = 49;
            // 
            // txbSynopsis
            // 
            this.txbSynopsis.Location = new System.Drawing.Point(150, 100);
            this.txbSynopsis.Multiline = true;
            this.txbSynopsis.Name = "txbSynopsis";
            this.txbSynopsis.Size = new System.Drawing.Size(391, 53);
            this.txbSynopsis.TabIndex = 45;
            // 
            // txbRealisateur
            // 
            this.txbRealisateur.Location = new System.Drawing.Point(150, 75);
            this.txbRealisateur.Name = "txbRealisateur";
            this.txbRealisateur.Size = new System.Drawing.Size(207, 20);
            this.txbRealisateur.TabIndex = 44;
            // 
            // txbDvdTitre
            // 
            this.txbDvdTitre.Location = new System.Drawing.Point(150, 50);
            this.txbDvdTitre.Name = "txbDvdTitre";
            this.txbDvdTitre.Size = new System.Drawing.Size(391, 20);
            this.txbDvdTitre.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 158);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Genre :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Public :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Rayon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Titre :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Réalisateur(trice) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Chemin de l\'image :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Synopsis :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Durée :";
            // 
            // FrmModifierDvD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 313);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmModifierDvD";
            this.Text = "FrmModifierDvD";
            this.Load += new System.EventHandler(this.FrmModifierDvD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_parcourir;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ComboBox cb_rayon;
        private System.Windows.Forms.PictureBox pcbLivresImage;
        private System.Windows.Forms.ComboBox cb_public;
        private System.Windows.Forms.ComboBox cb_genre;
        private System.Windows.Forms.Button btn_modifierDvD;
        private System.Windows.Forms.TextBox txbDuree;
        private System.Windows.Forms.TextBox txbDvdImage;
        private System.Windows.Forms.TextBox txbSynopsis;
        private System.Windows.Forms.TextBox txbRealisateur;
        private System.Windows.Forms.TextBox txbDvdTitre;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
    }
}