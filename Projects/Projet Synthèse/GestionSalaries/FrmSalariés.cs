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
        Commercial commercial;


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
                    button1Nouveau.Enabled = true;
                    groupBox1.Visible = true;
                    flowLayoutPanel1.Enabled = true;
                    button2Modifier.Enabled = true;
                    button3Annuler.Enabled = false;
                    button4Valider.Enabled = false;
                    textBoxMatricule.ReadOnly = true;
                    textBoxNom.ReadOnly = true;
                    textBoxPrenom.ReadOnly = true;
                    textBoxSalaireBrut.ReadOnly = true;
                    textBoxDatedeNaissance.ReadOnly = true;
                    textBoxTauxCS.ReadOnly = true;
                    textBoxChiffreAffaire.ReadOnly = true;
                    textBoxCommission.ReadOnly = true;
                    etat = Contextes.Consultation;


                    break;
                case Contextes.Modification:
                    button1Nouveau.Enabled = false;
                    groupBox1.Visible = true;                     
                    flowLayoutPanel1.Enabled = true;
                    button2Modifier.Enabled = false;
                    button3Annuler.Enabled = true;
                    button4Valider.Enabled = false ;
                    textBoxMatricule.ReadOnly = true;
                    textBoxNom.ReadOnly = false;
                    textBoxPrenom.ReadOnly = false;
                    textBoxSalaireBrut.ReadOnly = false;
                    textBoxDatedeNaissance.ReadOnly = false;
                    textBoxTauxCS.ReadOnly = false;
                    textBoxChiffreAffaire.ReadOnly = false;
                    textBoxCommission.ReadOnly = false;
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
                    button1Nouveau.Enabled = false;
                    groupBox1.Visible = true;
                    flowLayoutPanel1.Enabled = true;
                    button2Modifier.Enabled = false;
                    button3Annuler.Enabled = true;
                    button4Valider.Enabled = false;
                    textBoxMatricule.ReadOnly = false;
                    textBoxNom.ReadOnly = false;
                    textBoxPrenom.ReadOnly = false;
                    textBoxSalaireBrut.ReadOnly = false;
                    textBoxDatedeNaissance.ReadOnly = false;
                    textBoxTauxCS.ReadOnly = false;
                    textBoxChiffreAffaire.ReadOnly = false;
                    textBoxCommission.ReadOnly = false;
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
            textBoxDatedeNaissance.Text=salarie.DateNaissance.ToString() ;              
            textBoxTauxCS.Text = salarie.TauxCS.ToString();
            //textBoxChiffreAffaire.Text = commercial.ChiffreAffaire.ToString();
            //textBoxCommission.Text = commercial.Commission.ToString();


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


        private bool IsChampValid()
        {
            bool matricule = true;
            if (!Salarie.IsMatriculeValide(textBoxMatricule.Text))
            {
                matricule = false;
                epSalarie.SetError(textBoxMatricule, "Le matricule n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxMatricule, string.Empty);
            }
            return matricule;
        }

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
            //commercial.ChiffreAffaire = Decimal.Parse(textBoxChiffreAffaire.Text);
            //commercial.Commission = Decimal.Parse(textBoxCommission.Text);
            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
            //save

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
            //commercial.ChiffreAffaire = Decimal.Parse(textBoxChiffreAffaire.Text);
            //commercial.Commission = Decimal.Parse(textBoxCommission.Text);
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




            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le nom n'est pas valide"); 
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
            }





            if (!Salarie.IsNomPrenomValide(textBoxPrenom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxPrenom, "Le prenom n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxPrenom, string.Empty);
            }



            if (!Salarie.IsDateNaissanceValide(DateTime.Parse(textBoxDatedeNaissance.Text)))
            {
                valid = false;
                epSalarie.SetError(textBoxDatedeNaissance, "La date de naissance n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxDatedeNaissance, string.Empty);
            }






            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le salaire brut n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
            }

            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le taux cs n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
            }


            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le chiffre affaire n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
            }


            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le commision n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
            }


            if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
            {
                valid = false;
                epSalarie.SetError(textBoxNom, "Le nom n'est pas valide");
            }
            else
            {
                epSalarie.SetError(textBoxNom, string.Empty);
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
            GestionnaireContextes(Contextes.ModificationAnnuler);
        }

        private void button2Modifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.Modification);
        }

        private void button1Nouveau_Click(object sender, EventArgs e)
        {
            
            NettoyageChamps();
            
            GestionnaireContextes(Contextes.AjoutInitial);


        }

        private void button4Valider_Click(object sender, EventArgs e)
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

        #endregion

         
    }
}


 