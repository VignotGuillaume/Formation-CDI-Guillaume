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
        bool etat = true;
        
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

        public FrmSalaries()
        {
            InitializeComponent();
        }

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


                    break;
                case Contextes.Modification:
                    button1Nouveau.Enabled = false;
                    groupBox1.Visible = true;
                    //flowLayoutPanel1.Enabled = false;
                    flowLayoutPanel1.Enabled = true;
                    button2Modifier.Enabled = false;
                    button3Annuler.Enabled = true;
                    button4Valider.Enabled = true;
                    textBoxMatricule.ReadOnly = true;
                    textBoxNom.ReadOnly = false;
                    textBoxPrenom.ReadOnly = false;
                    textBoxSalaireBrut.ReadOnly = false;
                    textBoxDatedeNaissance.ReadOnly = false;
                    textBoxTauxCS.ReadOnly = false;
                    textBoxChiffreAffaire.ReadOnly = false;
                    textBoxCommission.ReadOnly = false;
                    
                    break;
                case Contextes.ModificationAnnuler:
                    ChargerValeursSalarie();
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.ModificationValider:
                    bool etat = false;                  
                    GestionnaireContextes(Contextes.Consultation);
                    break;
                case Contextes.AjoutInitial:
                    button1Nouveau.Enabled = false;
                    groupBox1.Visible = true;
                    flowLayoutPanel1.Enabled = true;
                    button2Modifier.Enabled = false;
                    button3Annuler.Enabled = true;
                    button4Valider.Enabled = true;
                    textBoxMatricule.ReadOnly = false;
                    textBoxNom.ReadOnly = false;
                    textBoxPrenom.ReadOnly = false;
                    textBoxSalaireBrut.ReadOnly = false;
                    textBoxDatedeNaissance.ReadOnly = false;
                    textBoxTauxCS.ReadOnly = false;
                    textBoxChiffreAffaire.ReadOnly = false;
                    textBoxCommission.ReadOnly = false;
                    break;
                case Contextes.AjoutValider:
                    etat = true;
                    
                    GestionnaireContextes(Contextes.Consultation);

                    break;
                default:
                    break;
            }

        }

        private void ChargerValeursSalarie()
        {
            textBoxMatricule.Text = salarie.Matricule;
            textBoxNom.Text = salarie.Nom;
            textBoxPrenom.Text = salarie.Prenom;
            textBoxSalaireBrut.Text = salarie.SalaireBrut.ToString();            
            textBoxDatedeNaissance.Text = salarie.DateNaissance.ToString();
            textBoxTauxCS.Text = salarie.TauxCS.ToString();
            //textBoxChiffreAffaire.Text = commercial.ChiffreAffaire.ToString();
            //textBoxCommission.Text = commercial.Commission.ToString();


        }
       
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

        private void ModifierSalarie()
        {            
            
                    salarie.Matricule = textBoxMatricule.Text;
                    salarie.Nom = textBoxNom.Text;
                    salarie.Prenom = textBoxPrenom.Text;
                    salarie.DateNaissance = DateTime.Parse(textBoxDatedeNaissance.Text);
                    salarie.SalaireBrut = Decimal.Parse(textBoxSalaireBrut.Text);
                    salarie.TauxCS = Decimal.Parse(textBoxTauxCS.Text);
            //commercial.ChiffreAffaire = Decimal.Parse(textBoxChiffreAffaire.Text);
            //commercial.Commission = Decimal.Parse(textBoxCommission.Text);
            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
            //save

        }
        
        private void ChargerSalaries()
        {
            salaries = new Salaries();
           
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Salarie item in salaries)
            {
                comboBox1ListeSalarie.Items.Add(item.Matricule);
            }
        }
        private void SauvegarderSalaries()
        {
           
            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);

        }

        //---------------------------------------------------------------------------------------

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

            GestionnaireContextes(Contextes.AjoutInitial);

           
        }

        private void button4Valider_Click(object sender, EventArgs e)
        {
            if (/*true*/)
            {
                ajout();
                ChargerSalaries();

                GestionnaireContextes(Contextes.Consultation);
            }
            else
            {
                ModifierSalarie();
                ChargerSalaries();
                GestionnaireContextes(Contextes.Consultation);
            }

            
            
        }

        private void ajout()

        {
           
            salarie = new Salarie();

            salarie.Matricule = textBoxMatricule.Text;
            salarie.Nom = textBoxNom.Text;
            salarie.Prenom = textBoxPrenom.Text;
            salarie.DateNaissance = DateTime.Parse(textBoxDatedeNaissance.Text);
            salarie.SalaireBrut = decimal.Parse(textBoxSalaireBrut.Text);
            salarie.TauxCS = decimal.Parse(textBoxTauxCS.Text);
            //commercial.ChiffreAffaire = Decimal.Parse(textBoxChiffreAffaire.Text);
            //commercial.Commission = Decimal.Parse(textBoxCommission.Text);
            salaries.Add(salarie);
            salaries.Save(MonApplication.DispositifSauvegarde, Settings.Default.AppData);
            }
           
        }
    }












    //--------------------------------------------------------------------------------

    //bool nom = true;
    //bool prenom = true;
    //bool dateNaissance = true;
    //bool salaireBrut = true;
    //bool tauxCs = true;
    //bool chiffreAffaire = true;
    //bool commission = true;


    //if (!Salarie.IsNomPrenomValide(textBoxNom.Text))
    //{
    //    nom = false;
    //    epSalarie.SetError(textBoxNom, "Le matricule n'est pas valide");

    //}
    //else
    //{
    //    epSalarie.SetError(textBoxNom, string.Empty);
    //}

    //return nom;
}




