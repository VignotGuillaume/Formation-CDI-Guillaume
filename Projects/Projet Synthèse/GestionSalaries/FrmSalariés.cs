using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;

namespace GestionSalaraies
{
    public partial class FrmSalaries : Form
    {
        Salaries salaries;
        Salarie salarie;
        // Commercial commercial;


        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            Modification = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6,
            SupprimerInitial = 7,
            SupprimerValider = 8


        }


        Contextes etat = Contextes.Consultation;

        public FrmSalaries()
        {
            InitializeComponent();
        }

        #region switch


        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    comboBox1ListeSalarie.Enabled = (comboBox1ListeSalarie.Items.Count > 0);
                    button1Nouveau.Enabled = true;
                    groupBox1.Visible = false;
                    break;


                case Contextes.Consultation:
                    groupBox1.Visible = true;
                    button1Nouveau.Enabled = true;
                    groupBox1.Enabled = true;
                    button2Modifier.Enabled = true;
                    button3Annuler.Enabled = false;
                    button4Valider.Enabled = false;
                    textBoxMatricule.Enabled = false;
                    textBoxNom.Enabled = false;
                    textBoxPrenom.Enabled = false;
                    textBoxSalaireBrut.Enabled = false;
                    textBoxDatedeNaissance.Enabled = false;
                    textBoxTauxCS.Enabled = false;
                    textBoxChiffreAffaire.Enabled = false;
                    textBoxCommission.Enabled = false;
                    etat = Contextes.Consultation;


                    break;
                case Contextes.Modification:
                    groupBox1.Visible = true;
                    button1Nouveau.Enabled = false;
                    groupBox1.Enabled = true;
                    button2Modifier.Enabled = false;
                    button3Annuler.Enabled = true;
                    button4Valider.Enabled = true;
                    textBoxMatricule.Enabled = false;
                    textBoxNom.Enabled = true;
                    textBoxPrenom.Enabled = true;
                    textBoxSalaireBrut.Enabled = true;
                    textBoxDatedeNaissance.Enabled = true;
                    textBoxTauxCS.Enabled = true;
                    textBoxChiffreAffaire.Enabled = true;
                    textBoxCommission.Enabled = true;
                    etat = Contextes.Modification;

                    break;
                case Contextes.ModificationAnnuler:
                    ChargerValeursSalarie();
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:

                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.AjoutInitial:
                    groupBox1.Visible = true;
                    button1Nouveau.Enabled = false;
                    groupBox1.Enabled = true;
                    button2Modifier.Enabled = false;
                    button3Annuler.Enabled = true;
                    button4Valider.Enabled = true;
                    textBoxMatricule.Enabled = true;
                    textBoxNom.Enabled = true;
                    textBoxPrenom.Enabled = true;
                    textBoxSalaireBrut.Enabled = true;
                    textBoxDatedeNaissance.Enabled = true;
                    textBoxTauxCS.Enabled = true;
                    textBoxChiffreAffaire.Enabled = true;
                    textBoxCommission.Enabled = true;
                    etat = Contextes.AjoutInitial;
                    break;
                case Contextes.AjoutValider:


                    GestionnaireContextes(Contextes.Consultation);

                    break;
                default:
                    break;
            }

        }
        #endregion

        #region Charger
        private void ChargerValeursSalarie()
        {
            textBoxMatricule.Text = salarie.Matricule;
            textBoxNom.Text = salarie.Nom;
            textBoxPrenom.Text = salarie.Prenom;
            textBoxSalaireBrut.Text = salarie.SalaireBrut.ToString();
            textBoxDatedeNaissance.Text = salarie.DateNaissance.ToString();
            textBoxTauxCS.Text = salarie.TauxCS.ToString();
            Commercial commercial = salarie as Commercial;
            if (commercial != null)
            {

                textBoxChiffreAffaire.Text = commercial.ChiffreAffaire.ToString();
                textBoxCommission.Text = commercial.Commission.ToString();
                textBoxChiffreAffaire.Visible = true;
                textBoxCommission.Visible = true;

            }
            else
            {
                textBoxChiffreAffaire.Visible = false;
                textBoxCommission.Visible = false;

            }


        }
        private void ChargerSalaries()
        {

            salaries = new Salaries();

            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            comboBox1ListeSalarie.Items.Clear();


            foreach (Salarie item in salaries)
            {
                comboBox1ListeSalarie.Items.Add(item.Matricule);
            }


        }

        #endregion dechargement

        #region  Sauvegarder
        private void SauvegarderSalaries()
        {

            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);

        }
        #endregion

        #region controle




        #endregion

        #region Ajout/Modif

        private void ModifierSalarie()
        {

            salarie.Matricule = textBoxMatricule.Text;
            salarie.Nom = textBoxNom.Text;
            salarie.Prenom = textBoxPrenom.Text;
            salarie.DateNaissance = DateTime.Parse(textBoxDatedeNaissance.Text);
            salarie.SalaireBrut = decimal.Parse(textBoxSalaireBrut.Text);
            salarie.TauxCS = decimal.Parse(textBoxTauxCS.Text.Replace(".", ","));

            Commercial commercial = salarie as Commercial;
            if (commercial != null)
            {
                commercial.ChiffreAffaire = Decimal.Parse(textBoxChiffreAffaire.Text);
                commercial.Commission = Decimal.Parse(textBoxCommission.Text);
            }

            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);

        }

        private void AjouterSalarie()

        {

            salarie = new Salarie();

            salarie.Matricule = textBoxMatricule.Text;
            salarie.Nom = textBoxNom.Text;
            salarie.Prenom = textBoxPrenom.Text;
            salarie.DateNaissance = DateTime.Parse(textBoxDatedeNaissance.Text);
            salarie.SalaireBrut = decimal.Parse(textBoxSalaireBrut.Text);
            salarie.TauxCS = decimal.Parse(textBoxTauxCS.Text.Replace(".", ","));

            Commercial commercial = salarie as Commercial;
            if (commercial != null)
            {
                commercial.ChiffreAffaire = Decimal.Parse(textBoxChiffreAffaire.Text);
                commercial.Commission = Decimal.Parse(textBoxCommission.Text);
            }

            salaries.Add(salarie);
            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);

        }

        private void NettoyageChamps()
        {
            textBoxMatricule.Clear();
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxDatedeNaissance.Clear();
            textBoxTauxCS.Clear();
            textBoxSalaireBrut.Clear();
            textBoxChiffreAffaire.Clear();
            textBoxCommission.Clear();
            comboBox1ListeSalarie.ResetText();
        }

        //private void SupprimerSalarie()
        //{

        //    MessageBox.Show("etes-vous sur");
        //  //cours++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++  
        //   DialogResult suppressionResult = MessageBox.ShowDialog();

        //    switch (suppressionResult)
        //    {
        //        case DialogResult.None:
        //            SuppressionModal.ShowDialog();
        //            break;

        //        case DialogResult.OK:
        //            salaries.Remove(salarie);
        //            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
        //            break;

        //        case DialogResult.Cancel:
        //            SuppressionModal.Close();
        //            Close();
        //            break;

        //    }
                   

        //}
        #endregion

        #region Validité


        private bool IsValidChamps()
        {
            bool valid = true;

            if (!Salarie.IsMatriculeValide(textBoxMatricule.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxMatricule, "Le matricule n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxMatricule, string.Empty);
            }
            //------------------------------------------------------------------------------------
            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le nom n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
            }
            //------------------------------------------------------------------------------------

            if (!Salarie.IsNomPrenomValide(textBoxPrenom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxPrenom, "Le prenom n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxPrenom, string.Empty);
            }
            //-----------------------------------------------------------------------------------
            DateTime naissanceConvertie;
            if (!DateTime.TryParse(textBoxDatedeNaissance.Text, out naissanceConvertie))
            {
                valid = false;
                epSalarie.SetError(textBoxDatedeNaissance, "La date de naissance n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxDatedeNaissance, string.Empty);
            }
            //---- ----------------------------------------------------- ----------------------
            decimal salaireConverti;
            if ((!decimal.TryParse(textBoxSalaireBrut.Text, out salaireConverti)) || decimal.Parse(textBoxSalaireBrut.Text) < 0)

            {
                valid = false;
                epSalarie.SetError(textBoxSalaireBrut, "Le salaire brut n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxSalaireBrut, string.Empty);
            }
            //---------------------------------------------------------------------------------
            decimal tauxcsConverti;
            if ((!decimal.TryParse(textBoxTauxCS.Text, out tauxcsConverti)) || decimal.Parse(textBoxTauxCS.Text) < 0 || decimal.Parse(textBoxTauxCS.Text) > 0.6m)
            {
                valid = false;
                epSalarie.SetError(textBoxTauxCS, "Le taux CS n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxTauxCS, string.Empty);
            }
            //--------------------------------------------------------------------------
            decimal chiffreaffaireConverti;
            if ((!decimal.TryParse(textBoxChiffreAffaire.Text, out chiffreaffaireConverti)) || decimal.Parse(textBoxChiffreAffaire.Text) < 0 || decimal.Parse(textBoxChiffreAffaire.Text) > 0.6m)

            {
                valid = false;
                epSalarie.SetError(textBoxChiffreAffaire, "Le chiffre d'affaire n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxChiffreAffaire, string.Empty);
            }
            //     //---- --------------------------------------------------------------------

            decimal commissionConverti;
            if ((!decimal.TryParse(textBoxCommission.Text, out commissionConverti)) || decimal.Parse(textBoxCommission.Text) < 0 || decimal.Parse(textBoxCommission.Text) > 0.6m)

                if ((textBoxCommission.Text) == null || int.Parse(textBoxCommission.Text) < 0)
                {
                    valid = false;
                    epSalarie.SetError(textBoxCommission, "Le taux de Commission n'est pas valide");
                }
                else
                {
                    epSalarie.SetError(textBoxCommission, string.Empty);
                }



            return valid;
        }



        #endregion 
        //---------------------------------------------------------------------------------------
        #region boutons

        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }

        private void comboBox1ListeSalarie_SelectedIndexChanged(object sender, EventArgs e)
        {

            salarie = salaries.SalarieByMatricule(comboBox1ListeSalarie.Items[comboBox1ListeSalarie.SelectedIndex].ToString());
            ChargerValeursSalarie();
            GestionnaireContextes(Contextes.Consultation);

        }

        private void button3Annuler_Click(object sender, EventArgs e)
        {

            if (etat == Contextes.Modification)
            {
                GestionnaireContextes(Contextes.ModificationAnnuler);

            }
            else
            {
                NettoyageChamps();
                GestionnaireContextes(Contextes.AjoutInitial);

            }

        }

        private void button2Modifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.Modification);


        }

        private void button1Nouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial);
            NettoyageChamps();

        }

        private void button4Valider_Click(object sender, EventArgs e)
        {
            if (IsValidChamps())
            {

                if (etat == Contextes.Modification)
                {
                    ModifierSalarie();

                }
                else
                {

                    AjouterSalarie();
                }

                GestionnaireContextes(Contextes.Consultation);

                ChargerSalaries();
            }
            else
            {
                GestionnaireContextes(Contextes.AjoutInitial);
            }

        }


        #endregion

        private void button1Effacer_Click(object sender, EventArgs e)
        {
            //GestionnaireContextes(Contextes.Consultation);
            //SupprimerSalarie();
            //GestionnaireContextes(Contextes.Initial);
            
        }
    }
}


