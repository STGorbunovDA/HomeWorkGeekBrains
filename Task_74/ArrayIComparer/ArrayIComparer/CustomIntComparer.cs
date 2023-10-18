namespace ArrayIComparer
{
    public class CustomIntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            //сортировка всех элементов от большого к малому
            //if ((x % 2 == 0 && y % 2 == 0) || (x % 2 == 1 && y % 2 == 1))
            //    return y.CompareTo(x);

            //if (x % 2 == 1) return 1;
            //else return -1;

            //сортировка чётных влево от малого к большому и нечётных вправа от малого к большому
            if ((x % 2 == 0 && y % 2 == 0) || (x % 2 == 1 && y % 2 == 1)) return x.CompareTo(y);
            else
            {
                if (x % 2 == 1) return 1;
                else return -1;
            }
        }
    }
}
