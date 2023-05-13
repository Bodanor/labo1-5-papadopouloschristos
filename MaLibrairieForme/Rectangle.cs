namespace MaLibrairieForme;

public class Rectangle : Forme, ISommets
{
    protected int _longueur;
    protected int _largeur;

    public Rectangle(int x = 0, int y = 0, int longueur = 0, int largeur = 0)
    {
        _longueur = longueur;
        _largeur = largeur;
        _coord.x = x;
        _coord.y = y;
    }

    public Rectangle(Coordonnees c, int longueur = 0, int largeur = 0)
    {
        _coord.x = c.x;
        _coord.y = c.y;
        _longueur = longueur;
        _largeur = largeur;
    }

    public Rectangle(Rectangle r)
    {
        _coord.x = r._coord.x;
        _coord.y =r._coord.y;
        _longueur = r.Longueur;
        _largeur = r.Largeur;
    }

    public int Longueur
    {
        get { return _longueur; }
        set { _longueur = value; }
    }

    public int Largeur
    {
        get {return _longueur; }
        set { _longueur = value; }
    }
    public override string ToString()
    {
        return "{COORD " + _coord.ToString() + " - VALEURS (L = " + _longueur + " / l = " + _largeur + ")}";
    }

    public override void Affiche()
    {
        Console.WriteLine("Rectangle :\t" + ToString());
    }

    public override bool CoordonneeEstDans(Coordonnees p)
    {
        return _coord.x <= p.x && p.x <= _coord.x + _longueur && _coord.y <= p.y && p.y <= _coord.y + _largeur;
    }

    public byte NbSommet
    {
        get { return 4; }
    }

}