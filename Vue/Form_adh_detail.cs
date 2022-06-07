using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_conservatoire_musique.Modele;

namespace gestion_conservatoire_musique.Vue
{
    public partial class Form_adh_detail : Form
    {

        private Adherent adh_detail;

        public Form_adh_detail()
        {
            InitializeComponent();
        }
        public Form_adh_detail(Adherent adh_a_modifier)
        {
            InitializeComponent();
            adh_detail = adh_a_modifier;
        }
        private void Form_adh_detail_Load(object sender, EventArgs e)
        {
            txt_formDetail_adhId.Text = adh_detail.Id.ToString();
            txt_formDetail_adhNom.Text = adh_detail.Nom;
            txt_formDetail_adhPrenom.Text = adh_detail.Prenom;
            txt_formDetail_adhTel.Text = adh_detail.Tel;
            txt_formDetail_adhAdresse.Text = adh_detail.Adresse;
            txt_formDetail_adhMail.Text = adh_detail.Mail;
        }

        private void btn_formDetail_valider_Click(object sender, EventArgs e)
        {
            if (txt_formDetail_adhTel.Text != "")
            {
                adh_detail.Tel = txt_formDetail_adhTel.Text;
            }

            if (txt_formDetail_adhAdresse.Text != "")
            {
                adh_detail.Adresse = txt_formDetail_adhAdresse.Text;
            }

            if (txt_formDetail_adhMail.Text != "")
            {
                adh_detail.Mail = txt_formDetail_adhMail.Text;
            }

            this.Close();

        }




    }
}
