namespace MaLibrairieForme;

public class Cercle : Forme
{
    protected int _rayon;

    public Cercle(int x = 0, int y = 0, int r = 0)
    {
        _rayon = r;
        _coord.x = x;
        _coord.y = y;

    }

    public Cercle(Coordonnees c, int r = 0)
    {
        _coord.x = c.x;
        _coord.y = c.y;
        _rayon = r;
    }
    public Cercle(Cercle c)
    {
        _rayon = c.Rayon;
        _coord.x = c._coord.x;
        _coord.y = c._coord.y;

    }

    public int Rayon
    {
        get { return _rayon; }
        set { _rayon = value; }
    }
    public override string ToString()
    {
        return "{COORD " + _coord.ToString() + " - VALEUR (r = " + _rayon + ")}";
    }
    public override void Affiche()
    {
        Console.WriteLine("Cercle :\t" + ToString());
    }

    public override bool CoordonneeEstDans(Coordonnees p)
    {
        return Math.Pow(p.x - _coord.x, 2) + Math.Pow(p.y - _coord.y, 2) <= Math.Pow(_rayon, 2);
    }

}