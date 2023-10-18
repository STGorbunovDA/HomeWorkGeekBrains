using ArrayIComparer;

IComparer<int> comparer = new CustomIntComparer();

int[] arr = new int[] { 1, 4, 2, 3 };

Array.Sort(arr, comparer);
foreach (int i in arr)
    Console.Write(i + " ");