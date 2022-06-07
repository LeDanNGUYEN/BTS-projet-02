
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
            this.panel_payee = new System.Windows.Forms.Panel();
            this.lbl_payee = new System.Windows.Forms.Label();
            this.lbl_inscription_lstboxInscriptionsAdh = new System.Windows.Forms.Label();
            this.btn_inscription_crediter = new System.Windows.Forms.Button();
            this.txt_inscription_crediter = new System.Windows.Forms.TextBox();
            this.btn_inscription_validationBool = new System.Windows.Forms.Button();
            this.btn_desinscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_adherent
            // 
            this.listBox_adherent.FormattingEnabled = true;
            this.listBox_adherent.ItemHeight = 16;
            this.listBox_adherent.Location = new System.Drawing.Point(21, 57);
            this.listBox_adherent.Name = "listBox_adherent";
            this.listBox_adherent.Size = new System.Drawing.Size(507, 292);
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
            this.btn_adherent_delete.Location = new System.Drawing.Point(21, 429);
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
            this.lbl_adherent_lstboxAdherent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_adherent_lstboxAdherent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_adherent_lstboxAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adherent_lstboxAdherent.Location = new System.Drawing.Point(18, 19);
            this.lbl_adherent_lstboxAdherent.Name = "lbl_adherent_lstboxAdherent";
            this.lbl_adherent_lstboxAdherent.Size = new System.Drawing.Size(178, 22);
            this.lbl_adherent_lstboxAdherent.TabIndex = 3;
            this.lbl_adherent_lstboxAdherent.Text = "Liste des adhérents";
            // 
            // listBox_adherent_inscription
            // 
            this.listBox_adherent_inscription.FormattingEnabled = true;
            this.listBox_adherent_inscription.ItemHeight = 16;
            this.listBox_adherent_inscription.Location = new System.Drawing.Point(559, 57);
            this.listBox_adherent_inscription.Name = "listBox_adherent_inscription";
            this.listBox_adherent_inscription.Size = new System.Drawing.Size(965, 292);
            this.listBox_adherent_inscription.TabIndex = 4;
            this.listBox_adherent_inscription.SelectedIndexChanged += new System.EventHandler(this.listBox_adherent_inscription_SelectedIndexChanged);
            // 
            // panel_payee
            // 
            this.panel_payee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_payee.Location = new System.Drawing.Point(559, 373);
            this.panel_payee.Name = "panel_payee";
            this.panel_payee.Size = new System.Drawing.Size(108, 32);
            this.panel_payee.TabIndex = 5;
            // 
            // lbl_payee
            // 
            this.lbl_payee.AutoSize = true;
            this.lbl_payee.Location = new System.Drawing.Point(693, 381);
            this.lbl_payee.Name = "lbl_payee";
            this.lbl_payee.Size = new System.Drawing.Size(136, 17);
            this.lbl_payee.TabIndex = 6;
            this.lbl_payee.Text = "label : payee ou pas";
            // 
            // lbl_inscription_lstboxInscriptionsAdh
            // 
            this.lbl_inscription_lstboxInscriptionsAdh.AutoSize = true;
            this.lbl_inscription_lstboxInscriptionsAdh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_inscription_lstboxInscriptionsAdh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_inscription_lstboxInscriptionsAdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inscription_lstboxInscriptionsAdh.Location = new System.Drawing.Point(559, 19);
            this.lbl_inscription_lstboxInscriptionsAdh.Name = "lbl_inscription_lstboxInscriptionsAdh";
            this.lbl_inscription_lstboxInscriptionsAdh.Size = new System.Drawing.Size(224, 22);
            this.lbl_inscription_lstboxInscriptionsAdh.TabIndex = 7;
            this.lbl_inscription_lstboxInscriptionsAdh.Text = "Inscriptions de l\'adhérent";
            // 
            // btn_inscription_crediter
            // 
            this.btn_inscription_crediter.Location = new System.Drawing.Point(921, 417);
            this.btn_inscription_crediter.Name = "btn_inscription_crediter";
            this.btn_inscription_crediter.Size = new System.Drawing.Size(126, 32);
            this.btn_inscription_crediter.TabIndex = 8;
            this.btn_inscription_crediter.Text = "crediter";
            this.btn_inscription_crediter.UseVisualStyleBackColor = true;
            this.btn_inscription_crediter.Click += new System.EventHandler(this.btn_inscription_crediter_Click);
            // 
            // txt_inscription_crediter
            // 
            this.txt_inscription_crediter.Location = new System.Drawing.Point(921, 378);
            this.txt_inscription_crediter.Name = "txt_inscription_crediter";
            this.txt_inscription_crediter.Size = new System.Drawing.Size(126, 22);
            this.txt_inscription_crediter.TabIndex = 9;
            // 
            // btn_inscription_validationBool
            // 
            this.btn_inscription_validationBool.Location = new System.Drawing.Point(696, 417);
            this.btn_inscription_validationBool.Name = "btn_inscription_validationBool";
            this.btn_inscription_validationBool.Size = new System.Drawing.Size(126, 32);
            this.btn_inscription_validationBool.TabIndex = 10;
            this.btn_inscription_validationBool.Text = "(in)validation";
            this.btn_inscription_validationBool.UseVisualStyleBackColor = true;
            this.btn_inscription_validationBool.Click += new System.EventHandler(this.btn_inscription_validationBool_Click);
            // 
            // btn_desinscription
            // 
            this.btn_desinscription.Location = new System.Drawing.Point(1398, 417);
            this.btn_desinscription.Name = "btn_desinscription";
            this.btn_desinscription.Size = new System.Drawing.Size(126, 32);
            this.btn_desinscription.TabIndex = 11;
            this.btn_desinscription.Text = "desinscrire";
            this.btn_desinscription.UseVisualStyleBackColor = true;
            this.btn_desinscription.Click += new System.EventHandler(this.btn_desinscription_Click);
            // 
            // Form_adh_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 491);
            this.Controls.Add(this.btn_desinscription);
            this.Controls.Add(this.btn_inscription_validationBool);
            this.Controls.Add(this.txt_inscription_crediter);
            this.Controls.Add(this.btn_inscription_crediter);
            this.Controls.Add(this.lbl_inscription_lstboxInscriptionsAdh);
            this.Controls.Add(this.lbl_payee);
            this.Controls.Add(this.panel_payee);
            this.Controls.Add(this.listBox_adherent_inscription);
            this.Controls.Add(this.lbl_adherent_lstboxAdherent);
            this.Controls.Add(this.btn_adherent_delete);
            this.Controls.Add(this.btn_adherent_modify);
            this.Controls.Add(this.listBox_adherent);
            this.Name = "Form_adh_principal";
            this.Text = "Formulaire adhérents : liste";
            this.Load += new System.EventHandler(this.Formadh_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_adherent;
        private System.Windows.Forms.Button btn_adherent_modify;
        private System.Windows.Forms.Button btn_adherent_delete;
        private System.Windows.Forms.Label lbl_adherent_lstboxAdherent;
        private System.Windows.Forms.ListBox listBox_adherent_inscription;
        private System.Windows.Forms.Panel panel_payee;
        private System.Windows.Forms.Label lbl_payee;
        private System.Windows.Forms.Label lbl_inscription_lstboxInscriptionsAdh;
        private System.Windows.Forms.Button btn_inscription_crediter;
        private System.Windows.Forms.TextBox txt_inscription_crediter;
        private System.Windows.Forms.Button btn_inscription_validationBool;
        private System.Windows.Forms.Button btn_desinscription;
    }
}

