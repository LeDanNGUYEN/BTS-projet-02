using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_conservatoire_musique.Controleur;
using gestion_conservatoire_musique.Modele;
using gestion_conservatoire_musique.Vue;

namespace gestion_conservatoire_musique
{
    public partial class Form_adh_principal : Form
    {

/*INITIALISATION & VARIABLE-----------------------------------------------------------------------*/

        Mgr monManager;
        public List<Adherent> liste_adh_form = new List<Adherent>();
        public List<Inscription> liste_inscription_form = new List<Inscription>();

        public Form_adh_principal()
        {
            InitializeComponent();
            monManager = new Mgr();
            
            lbl_payee.Visible = false;
            panel_payee.Visible = false;
            
            txt_inscription_crediter.Visible = false;
            btn_inscription_crediter.Enabled = false;
            btn_inscription_crediter.Visible = false;

            btn_inscription_validationBool.Enabled = false;
            btn_inscription_validationBool.Visible = false;

        }

        private void Formadh_principal_Load(object sender, EventArgs e)
        {
            liste_adh_form = monManager.chargement_liste_adh();
            if(liste_adh_form.Count != 0) 
            { 
                update_listbox_adh(0); 
            }
        }


/*UPDATE CLICK SUR LISTBOX --------------------------------------------------------------------------------------------*/

        /*METHODE : click (ou pas) listbox des adherents, affichant les inscriptions dans la 2e listbox*/
        private void listBox_adherent_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = listBox_adherent.SelectedIndex;

            if (i != -1)
            {

                /*Adherent adh_selectionne = (Adherent)liste_adh_form[i];*/
                Adherent adh_selectionne = liste_adh_form[i];

                liste_inscription_form = monManager.chargement_liste_inscription(adh_selectionne);

                if (liste_inscription_form.Count != 0)
                {
                    update_listbox_inscription(0);
                }
                else
                {
                    update_listbox_inscription_rien();
                }

            }

        }

        /*METHODE : click (ou pas) listbox des inscriptions, pour voir l'état du paiement de celle-ci*/
        private void listBox_adherent_inscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox_adherent_inscription.SelectedIndex;

            if (i != -1)
            {
                Inscription inscription_adh_choisie = liste_inscription_form[i];
                panelPaye_colorChange(inscription_adh_choisie.Inscription_validee);

                btnValidation_texteUpdate(inscription_adh_choisie);

            }
            else
            {
                panel_payee.BackColor = Color.DarkGray;
                panel_payee.Visible = true;

                lbl_payee.Visible = true;
                lbl_payee.Text = "PAS D'INSCRIPTION";

                txt_inscription_crediter.Visible = false;

                btn_inscription_crediter.Enabled = false;
                btn_inscription_crediter.Visible = false;

            }

        }


/*METHODE : CLICK BUTTON --------------------------------------------------------------------*/

        private void btn_adherent_modify_Click(object sender, EventArgs e)
        {

            int i;
            i = listBox_adherent.SelectedIndex;

            Adherent adh_selectionne_modif = liste_adh_form[i];

            Form_adh_detail form_adh_detail_vue = new Form_adh_detail(adh_selectionne_modif);
            form_adh_detail_vue.ShowDialog();

            monManager.update_adh_info(adh_selectionne_modif);

            liste_adh_form = monManager.chargement_liste_adh();

            update_listbox_adh(i);
            MessageBox.Show("Modification effectuee","Modification adhérent");

        }

        private void btn_adherent_delete_Click(object sender, EventArgs e)
        {

            int i;
            i = listBox_adherent.SelectedIndex;

            if (i != -1)
            {
                Adherent adh_selectionne_suppr = liste_adh_form[i];

                DialogResult user_choix;

                user_choix = MessageBox.Show("Voulez-vous vraiment le supprimer ?", "Suppression adherent",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (user_choix == DialogResult.Yes)
                {

                    monManager.delete_adh(adh_selectionne_suppr);

                    liste_adh_form = monManager.chargement_liste_adh();

                    try
                    {
                        update_listbox_adh(i);
                    }
                    catch (Exception emp)
                    {
                        MessageBox.Show("Erreur suppression", "Suppression adherent");
                    }
                    MessageBox.Show("FIN opération SUPPRESSION", "Suppression adherent");
                }
            }

        }


        private void btn_inscription_crediter_Click(object sender, EventArgs e)
        {

            int i;
            i = listBox_adherent_inscription.SelectedIndex;

            if(i != -1) /*TEST : il faut AU MOINS 1 inscription dans la listbox des inscriptions*/
            {

                Inscription inscription_a_crediter = liste_inscription_form[i];
                int montant_aCrediter = 0;

                try
                {
                    montant_aCrediter = Convert.ToInt32(txt_inscription_crediter.Text);

                    inscription_a_crediter.modifier_inscription_credit(inscription_a_crediter, montant_aCrediter);

                    /*A MODIFIER*/
                    monManager.update_inscription_credit(inscription_a_crediter);

                    liste_inscription_form = monManager.chargement_liste_inscription(inscription_a_crediter.Adherent_inscription_selectionne);

                    update_listbox_inscription(i);
                }
                catch
                {
                    MessageBox.Show("Entrée utilisateur invalide - valeur numérique attendue","Crédit inscription");
                }

                txt_inscription_crediter.Text = "";
                MessageBox.Show("FIN opération CREDIT", "Crédit inscription");

            } 
            else
            {
                MessageBox.Show("ERREUR - Inscription déjà validée", "Crédit inscription");
            }

        }


        private void btn_inscription_validationBool_Click(object sender, EventArgs e)
        {
            int i = listBox_adherent_inscription.SelectedIndex;
            Inscription inscription_adh_choisie = liste_inscription_form[i];
            
            string instruction = btn_inscription_validationBool.Text;

            try
            {
                if (instruction == "valider")
                {
                    inscription_adh_choisie.Inscription_validee = 1;
                }
                else if (instruction == "invalider")
                {
                    inscription_adh_choisie.Inscription_validee = 0;
                }

                monManager.update_inscription_credit(inscription_adh_choisie);

                liste_inscription_form = monManager.chargement_liste_inscription(inscription_adh_choisie.Adherent_inscription_selectionne);

                update_listbox_inscription(i);

            }
            catch (Exception emp)
            {
                MessageBox.Show("Demande inconnue", "Validation/Invalidation inscription");
            }
        }


        private void btn_desinscription_Click(object sender, EventArgs e)
        {
            int i = listBox_adherent_inscription.SelectedIndex;

            if (i != -1)
            {
                Inscription inscription_adh_choisie = liste_inscription_form[i];

                DialogResult user_choix;

                user_choix = MessageBox.Show("Voulez-vous vraiment désinscrire ?", "Suppression inscription",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (user_choix == DialogResult.Yes)
                {

                    monManager.delete_inscription(inscription_adh_choisie);

                    liste_inscription_form = monManager.chargement_liste_inscription(inscription_adh_choisie.Adherent_inscription_selectionne);

                    try
                    {
                        update_listbox_inscription(i);
                    }
                    catch (Exception emp)
                    {
                        MessageBox.Show("Erreur suppression","Suppression inscription");
                    }
                    MessageBox.Show("FIN opération DESINSCRIPTION", "Suppression inscription");
                }
            }
        }



/* FONCTIONS POUR CHARGER/UPDATE LES LISTBOX -----------------------------------------------------------------------------*/

        /*METHODE ADHERENTS : charger-update listbox des ADHERENTS*/
        private void update_listbox_adh(int index)
        {
            listBox_adherent.DataSource = null;
            listBox_adherent.DataSource = liste_adh_form;
            /*listBox_adherent.DisplayMember = Description;*/ /* PAS BESOIN, cela fait appel au toString */
            listBox_adherent.SetSelected(index, true);
        }

        /*METHODE INSCRIPTIONS : update listbox des INSCRIPTIONS, pour AUCUN adherent selectionne*/
        private void update_listbox_inscription_rien()
        {
            listBox_adherent_inscription.DataSource = null;
            /*listBox_adherent_inscription.DisplayMember = "Description";*/
        }

        /*METHODE INSCRIPTIONS : update listbox des INSCRIPTIONS, pour 1 adherent selectionne*/
        private void update_listbox_inscription(int index)
        {
            listBox_adherent_inscription.DataSource = null;
            // lBox.DataSource = lstcpt.Values.ToList();
            listBox_adherent_inscription.DataSource = liste_inscription_form;
            /*listBox_adherent_inscription.DisplayMember = "Description";*/
            listBox_adherent_inscription.SetSelected(index, true);

        }

/* FONCTIONS POUR CHARGER/UPDATE LES BOUTONS/ECRANS et leurs fonctions -----------------------------------------------------------------------------*/
        private void panelPaye_colorChange(int boolColor)
        {
            if(boolColor == 0)
            {
                panel_payee.BackColor = Color.Red;
                panel_payee.Visible = true;
                lbl_payee.Text = "INSCRIPTION NON PAYEE";
                lbl_payee.Visible = true;
                txt_inscription_crediter.Visible = true;
                btn_inscription_crediter.Enabled = true;
                btn_inscription_crediter.Visible = true;
            } 
            else if(boolColor == 1)
            {
                panel_payee.BackColor = Color.Green;
                panel_payee.Visible = true;
                lbl_payee.Text = "INSCRIPTION PAYEE";
                lbl_payee.Visible = true;
                txt_inscription_crediter.Visible = true;
                btn_inscription_crediter.Enabled = true;
                btn_inscription_crediter.Visible = true;
            }
            else /*Pas utile*/
            {
                panel_payee.BackColor = Color.Black;
                panel_payee.Visible = false;
                lbl_payee.Text = "A DEFINIR";
                lbl_payee.Visible = false;
                txt_inscription_crediter.Visible = false;
                btn_inscription_crediter.Enabled = false;
                btn_inscription_crediter.Visible = false;
            }
        }


        private void btnValidation_texteUpdate(Inscription inscription_selectionnee)
        {
            btn_inscription_validationBool.Enabled = true;
            btn_inscription_validationBool.Visible = true;

            if (inscription_selectionnee.Inscription_validee == 1)
            {
                btn_inscription_validationBool.Text = "invalider";
            } 
            else if(inscription_selectionnee.Inscription_validee == 0)
            {
                btn_inscription_validationBool.Text = "valider";
            }
            else
            {
                btn_inscription_validationBool.Enabled = true;
                btn_inscription_validationBool.Text = "(in)validation-inconnu";
                btn_inscription_validationBool.Visible = true;
            }
        }


        private void  validationOuNon(string instruction)
        {
            int i = listBox_adherent_inscription.SelectedIndex;
            Inscription inscription_adh_choisie = liste_inscription_form[i];

            try
            {
                if(instruction == "valider")
                {
                    inscription_adh_choisie.Inscription_validee = 1;
                }
                else if(instruction == "invalider")
                {
                    inscription_adh_choisie.Inscription_validee = 0;
                }

                monManager.update_inscription_credit(inscription_adh_choisie);

                liste_inscription_form = monManager.chargement_liste_inscription(inscription_adh_choisie.Adherent_inscription_selectionne);

                update_listbox_inscription(i);

            }
            catch (Exception emp)
            {

            }


        }


    }
}
