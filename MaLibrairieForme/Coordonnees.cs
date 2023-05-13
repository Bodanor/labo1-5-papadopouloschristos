namespace MaLibrairieForme
{
    public class Coordonnees
    {
        #region MEMBER_VARIABLES

        private int _x;
        private int _y;

        #endregion

        #region CONSTRUCTORS

        public Coordonnees(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;
        }

        public Coordonnees(Coordonnees c)
        {
            _x = c._x;
            _y = c._y;
        }

        #endregion

        #region GETTERS_SETTERS

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion

        #region METHODS

        public override string ToString()
        {
            return "(" + _x + ", " + _y + ")";
        }

        #endregion
    }
}