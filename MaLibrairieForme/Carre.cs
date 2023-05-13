namespace MaLibrairieForme;

public class Carre : Forme, ISommets, IComparable<Carre>
{
    protected int _longueur;

    public Carre(int x= 0, int y =0, int l = 0)
    {
        _coord.x = x;
        _coord.y = y;
        _longueur = l;
    }

    public Carre(Coordonnees c, int l = 0)
    {
        _coord.x = c.x;
        _coord.y = c.y;
        _longueur = l;
    }

    public override string ToString()
    {
        return "{COORD " + _coord.ToString() + " - VALEUR (c = " + _longueur + ")}";
    }

    public Carre(Carre c)
    {
        _coord.x = c.Coord.x;
        _coord.y = c.Coord.y;
        _longueur = c.Longueur;
    }

    public int Longueur
    {
        get { return _longueur; }
        set { _longueur = value; }

    }

    public override void Affiche()
    {
        Console.WriteLine("Carré :\t\t" + ToString());
    }

    public override bool CoordonneeEstDans(Coordonnees p)
    {
        return _coord.x <= p.x && p.x <= _coord.x + _longueur && _coord.y <= p.y && p.y <= _coord.y + _longueur;
    }

    public byte NbSommet
    {
        get { return 4; }
    }

    public int CompareTo(Carre other)
    {
        return Longueur.CompareTo(other.Longueur);
    }
}