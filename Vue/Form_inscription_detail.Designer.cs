
namespace gestion_conservatoire_musique
{
    partial class Form_inscription_detail
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
            this.lbl_inscription_lstboxAdherent = new System.Windows.Forms.Label();
            this.lbl_formDetail_adhId = new System.Windows.Forms.Label();
            this.txt_formDetail_adhId = new System.Windows.Forms.TextBox();
            this.btn_formDetail_valider = new System.Windows.Forms.Button();
            this.txt_formDetail_adhAdresse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_inscription_lstboxAdherent
            // 
            this.lbl_inscription_lstboxAdherent.AutoSize = true;
            this.lbl_inscription_lstboxAdherent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_inscription_lstboxAdherent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_inscription_lstboxAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inscription_lstboxAdherent.Location = new System.Drawing.Point(12, 9);
            this.lbl_inscription_lstboxAdherent.Name = "lbl_inscription_lstboxAdherent";
            this.lbl_inscription_lstboxAdherent.Size = new System.Drawing.Size(246, 22);
            this.lbl_inscription_lstboxAdherent.TabIndex = 4;
            this.lbl_inscription_lstboxAdherent.Text = "Inscription - détail paiement";
            // 
            // lbl_formDetail_adhId
            // 
            this.lbl_formDetail_adhId.AutoSize = true;
            this.lbl_formDetail_adhId.Location = new System.Drawing.Point(40, 74);
            this.lbl_formDetail_adhId.Name = "lbl_formDetail_adhId";
            this.lbl_formDetail_adhId.Size = new System.Drawing.Size(21, 17);
            this.lbl_formDetail_adhId.TabIndex = 5;
            this.lbl_formDetail_adhId.Text = "ID";
            // 
            // txt_formDetail_adhId
            // 
            this.txt_formDetail_adhId.Location = new System.Drawing.Point(132, 74);
            this.txt_formDetail_adhId.Name = "txt_formDetail_adhId";
            this.txt_formDetail_adhId.ReadOnly = true;
            this.txt_formDetail_adhId.Size = new System.Drawing.Size(139, 22);
            this.txt_formDetail_adhId.TabIndex = 9;
            // 
            // btn_formDetail_valider
            // 
            this.btn_formDetail_valider.Location = new System.Drawing.Point(43, 341);
            this.btn_formDetail_valider.Name = "btn_formDetail_valider";
            this.btn_formDetail_valider.Size = new System.Drawing.Size(81, 26);
            this.btn_formDetail_valider.TabIndex = 14;
            this.btn_formDetail_valider.Text = "Valider";
            this.btn_formDetail_valider.UseVisualStyleBackColor = true;
            // 
            // txt_formDetail_adhAdresse
            // 
            this.txt_formDetail_adhAdresse.Location = new System.Drawing.Point(132, 145);
            this.txt_formDetail_adhAdresse.Name = "txt_formDetail_adhAdresse";
            this.txt_formDetail_adhAdresse.Size = new System.Drawing.Size(139, 22);
            this.txt_formDetail_adhAdresse.TabIndex = 15;
            // 
            // Form_inscription_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_formDetail_adhAdresse);
            this.Controls.Add(this.btn_formDetail_valider);
            this.Controls.Add(this.txt_formDetail_adhId);
            this.Controls.Add(this.lbl_formDetail_adhId);
            this.Controls.Add(this.lbl_inscription_lstboxAdherent);
            this.Name = "Form_inscription_detail";
            this.Text = "Form_inscription_detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inscription_lstboxAdherent;
        private System.Windows.Forms.Label lbl_formDetail_adhId;
        private System.Windows.Forms.TextBox txt_formDetail_adhId;
        private System.Windows.Forms.Button btn_formDetail_valider;
        private System.Windows.Forms.TextBox txt_formDetail_adhAdresse;
    }
}