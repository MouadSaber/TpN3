using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_n3
{
    ///<summary>
    /// Une calculatrice de base
    ///</summary>
    public partial class Form1 : Form
    {
        #region Le constructeur par défaut
        ///<summary>
        /// Un constructeur qui permet de créer l'objet form1 dans la mémoire et l'initialise à valeur 'NULL'
        ///</summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Les méthodes de nombres
        ///<summary>
        /// Une méthode qui insére le texte 0 à la position du curseur
        ///</summary>
        private void Butt0_Click(object sender, EventArgs e)
        {
            InsererValeur("0");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 1 à la position du curseur
        ///</summary>
        private void Butt1_Click(object sender, EventArgs e)
        {
            InsererValeur("1");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 2 à la position du curseur
        ///</summary>
        private void Butt2_Click(object sender, EventArgs e)
        {
            InsererValeur("2");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 3 à la position du curseur
        ///</summary>
        private void Butt3_Click(object sender, EventArgs e)
        {
            InsererValeur("3");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 4 à la position du curseur
        ///</summary>
        private void Butt4_Click(object sender, EventArgs e)
        {
            InsererValeur("4");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 5 à la position du curseur
        ///</summary>
        private void Butt5_Click(object sender, EventArgs e)
        {
            InsererValeur("5");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 6 à la position du curseur
        ///</summary>
        private void Butt6_Click(object sender, EventArgs e)
        {
            InsererValeur("6");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 7 à la position du curseur
        ///</summary>
        private void Butt7_Click(object sender, EventArgs e)
        {
            InsererValeur("7");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 8 à la position du curseur
        ///</summary>
        private void Butt8_Click(object sender, EventArgs e)
        {
            InsererValeur("8");

            // l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte 9 à la position du curseur
        ///</summary>
        private void Butt9_Click(object sender, EventArgs e)
        {
            InsererValeur("9");

            // l'appel de méthode focusZone();
            focusZone();
        }
        #endregion
        #region Les méthodes de calcul
        ///<summary>
        /// Une méthode qui insére le texte "." à la position du curseur
        ///</summary>
        private void ButtPoint_Click(object sender, EventArgs e)
        {
            InsererValeur(".");

            /// l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte "^" à la position du curseur
        ///</summary>
        private void ButtCarre_Click(object sender, EventArgs e)
        {
            InsererValeur("^");

            /// l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui permet de calculer et afficher le résultat
        ///</summary>
        private void ButtEqual_Click(object sender, EventArgs e)
        {
            calculer();

            /// l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte "/" à la position du curseur
        ///</summary>
        private void ButtDiv_Click(object sender, EventArgs e)
        {
            InsererValeur("/");

            /// l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte "x" à la position du curseur
        ///</summary>
        private void ButtMult_Click(object sender, EventArgs e)
        {
            InsererValeur("x");

            /// l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte "-" à la position du curseur
        ///</summary>
        private void ButtMoins_Click(object sender, EventArgs e)
        {
            InsererValeur("-");

            /// l'appel de méthode focusZone();
            focusZone();
        }
        ///<summary>
        /// Une méthode qui insére le texte "+" à la position du curseur
        ///</summary>
        private void ButtPlus_Click(object sender, EventArgs e)
        {
            InsererValeur("+");

            /// l'appel de méthode focusZone();
            focusZone();
        }
        #endregion
        #region Méthodes de suppression 
        /// <summary>
        /// méthode qui permet de supprimer tout la ligne du texte de zone de texte
        /// </summary>
        private void ButtSuppTout_Click(object sender, EventArgs e)
        {
            this.InputText.Text = string.Empty;

            
            focusZone();
        }
        /// <summary>
        /// méthode qui permet de supprimer le dernier caractère a inséré
        /// </summary>
        private void ButtRetour_Click(object sender, EventArgs e)
        {
            // l'appel de méthode supprimer()
            SupprimerText();

            // l'appel de méthode focusZone()
            focusZone();

        }

        private void ButtSupp_Click(object sender, EventArgs e)
        {


            // l'appel de méthode focusZone();
            focusZone();
        }
        #endregion
        #region Autres méthodes
        ///<summary>
        /// Une méthode qui permet de mettre le focus sur l zone de texte chaque fois qu'on l'appele
        ///</summary>
        private void focusZone()
        {
           
            this.InputText.Focus();
        }
        ///<summary>
        /// une méthode qui permet d'insérer un texte à la position du curseur 
        ///</summary>
        private void InsererValeur(string chaine)
        {
            // le garde de position du curseur dans une nouvelle variable
            var selectionStart = this.InputText.SelectionStart;

            if(this.InputText.Text == "0") {
                this.InputText.Text = chaine;
            else
                this.InputText.Text += chaine
        }

        ///<summary>
        /// une méthode qui permet de supprimer un texte à la position du curseur 
        ///</summary>
        private void SupprimerText()
        {
            // le test si la langeur de texte dans la zone est inférieur à la langeur de texte a inséré
            if (this.InputText.Text.Length < this.InputText.SelectionStart + 1)
                return;                 // si on a pas de caractères à supprimer la mthd va retourne rien

            // le garde de position du curseur dans une nouvelle variable
            var selectionStart = this.InputText.SelectionStart;

            // la suppression du texte à la position du curseur
            this.InputText.Text = this.InputText.Text.Remove(this.InputText.SelectionStart, 1);

            // la réinitialisation de valeur de variable selectionStart à sa valeur initiale 
            this.InputText.SelectionStart = selectionStart ;

            this.InputText.SelectionLength = 0;
       
        }
        private void calculer()
        {
            // le stock de tout le texte a inséré dans la zone de texte
            var s = this.InputText.Text;

            // la récuperation de valeur de la mthd transforemr dans une variable 
            this.Label.Text= Transformer();


            focusZone();

        }
        private string Transformer()
        {
            try
            {
                throw new ArgumentNullException("Quelque chose est null");
            }
            catch (Exception ex)
            {
                var m = "Equation non validée";
                return m;
            }
        }
        #endregion
    }
}
