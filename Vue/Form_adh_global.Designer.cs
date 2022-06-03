
namespace gestion_conservatoire_musique
{
    partial class Form_adh_principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_adherent = new System.Windows.Forms.ListBox();
            this.btn_adherent_modify = new System.Windows.Forms.Button();
            this.btn_adherent_delete = new System.Windows.Forms.Button();
            this.lbl_adherent_lstboxAdherent = new System.Windows.Forms.Label();
            this.listBox_adherent_inscription = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_adherent
            // 
            this.listBox_adherent.FormattingEnabled = true;
            this.listBox_adherent.ItemHeight = 16;
            this.listBox_adherent.Location = new System.Drawing.Point(21, 57);
            this.listBox_adherent.Name = "listBox_adherent";
            this.listBox_adherent.Size = new System.Drawing.Size(577, 292);
            this.listBox_adherent.TabIndex = 0;
            this.listBox_adherent.SelectedIndexChanged += new System.EventHandler(this.listBox_adherent_SelectedIndexChanged);
            // 
            // btn_adherent_modify
            // 
            this.btn_adherent_modify.Location = new System.Drawing.Point(21, 373);
            this.btn_adherent_modify.Name = "btn_adherent_modify";
            this.btn_adherent_modify.Size = new System.Drawing.Size(227, 32);
            this.btn_adherent_modify.TabIndex = 1;
            this.btn_adherent_modify.Text = "modifier";
            this.btn_adherent_modify.UseVisualStyleBackColor = true;
            this.btn_adherent_modify.Click += new System.EventHandler(this.btn_adherent_modify_Click);
            // 
            // btn_adherent_delete
            // 
            this.btn_adherent_delete.Location = new System.Drawing.Point(271, 373);
            this.btn_adherent_delete.Name = "btn_adherent_delete";
            this.btn_adherent_delete.Size = new System.Drawing.Size(227, 32);
            this.btn_adherent_delete.TabIndex = 2;
            this.btn_adherent_delete.Text = "supprimer";
            this.btn_adherent_delete.UseVisualStyleBackColor = true;
            this.btn_adherent_delete.Click += new System.EventHandler(this.btn_adherent_delete_Click);
            // 
            // lbl_adherent_lstboxAdherent
            // 
            this.lbl_adherent_lstboxAdherent.AutoSize = true;
            this.lbl_adherent_lstboxAdherent.Location = new System.Drawing.Point(18, 19);
            this.lbl_adherent_lstboxAdherent.Name = "lbl_adherent_lstboxAdherent";
            this.lbl_adherent_lstboxAdherent.Size = new System.Drawing.Size(133, 17);
            this.lbl_adherent_lstboxAdherent.TabIndex = 3;
            this.lbl_adherent_lstboxAdherent.Text = "Liste des adhérents";
            // 
            // listBox_adherent_inscription
            // 
            this.listBox_adherent_inscription.FormattingEnabled = true;
            this.listBox_adherent_inscription.ItemHeight = 16;
            this.listBox_adherent_inscription.Location = new System.Drawing.Point(645, 57);
            this.listBox_adherent_inscription.Name = "listBox_adherent_inscription";
            this.listBox_adherent_inscription.Size = new System.Drawing.Size(677, 292);
            this.listBox_adherent_inscription.TabIndex = 4;
            this.listBox_adherent_inscription.SelectedIndexChanged += new System.EventHandler(this.listBox_adherent_inscription_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 450);
            this.Controls.Add(this.listBox_adherent_inscription);
            this.Controls.Add(this.lbl_adherent_lstboxAdherent);
            this.Controls.Add(this.btn_adherent_delete);
            this.Controls.Add(this.btn_adherent_modify);
            this.Controls.Add(this.listBox_adherent);
            this.Name = "Form1";
            this.Text = "Formulaire adhérents : liste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_adherent;
        private System.Windows.Forms.Button btn_adherent_modify;
        private System.Windows.Forms.Button btn_adherent_delete;
        private System.Windows.Forms.Label lbl_adherent_lstboxAdherent;
        private System.Windows.Forms.ListBox listBox_adherent_inscription;
    }
}

