internal class SpecialComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x.ToString().Length.CompareTo(y.ToString().Length);
    }
}