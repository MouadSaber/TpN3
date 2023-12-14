using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_n3
{
    /// <summary>
    /// informations sur une seule opération
    /// </summary>
    public class Opertion
    {
        #region Constructeur

        /// <summary>
        /// Constructeur par défaut de notre nouvelle classe
        /// </summary>
        public Opertion()
        {
            // la création des chaines de caractères vides (et pas des valeurs NULL)
            this.droite = string.Empty;
            this.gauche = string.Empty;
        }
        #endregion
        #region propriétés

        /// <summary>
        /// la partie gauche de l'opérateur
        /// </summary>
        public string gauche { get; set; }

        /// <summary>
        /// la partie droite de l'opérateur
        /// </summary>
        public string droite { get; set; }

        /// <summary>
        /// le type d'opération
        /// </summary>
        public Operations op { get; set; }

        public Opertion inner { get; set; }


        #endregion


    }
}
