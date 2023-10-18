namespace SearchIsCapital
{
    public static class Capital
    {
        public static bool IsCapital(string s)
        {
            foreach (char c in s)
                if (!Char.IsUpper(c)) return false;
            return true;
        }

        public static bool IsEvenRemove(int i)
        {
            return i % 2 == 0;
        }
    }
}
