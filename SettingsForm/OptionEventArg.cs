using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SettingsForm
{
    public class OptionEventArgs : EventArgs
    {
        #region MEMBER VARIABLES
        private int _taille;
        private Color _couleur;
        #endregion

        #region CONSTRUCTORS
        public OptionEventArgs(int taille, Color couleur)
        {
            _taille = taille;
            _couleur = couleur;
        }
        #endregion

        #region GETTERS/SETTERS
        public int Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public Color Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        #endregion
    }
}