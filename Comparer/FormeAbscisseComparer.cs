using MaLibrairieForme;

namespace Comparer

{
    public class FormeAbscisseComparer : IComparer<Forme>
    {
        public int Compare(Forme x, Forme y)
        {
            return x.Coord.x.CompareTo(y.Coord.x);
        }
    }
}