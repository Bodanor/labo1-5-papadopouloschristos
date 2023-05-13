namespace MaLibrairieForme;

 public abstract class Forme
{
    #region MEMBER_VARIABLES
    protected Coordonnees _coord;
    #endregion

    #region CONSTRUCTORS

    public Forme()
    {
        _coord = new Coordonnees();
    }
    #endregion

    #region GETTERS_SETTERS

    public Coordonnees Coord

    {
        get { return _coord; }
        set { _coord = value; }
    }
    #endregion

    #region METHODS

    public abstract void Affiche();
    public abstract bool CoordonneeEstDans(Coordonnees p);

    #endregion

}