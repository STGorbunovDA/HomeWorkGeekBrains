namespace ListDicSortrRpeatable.Base
{
    public static class GetDictionaryClass
    {
        static readonly Dictionary<int, int> dict = new();
        public static Dictionary<int, int> GetDictionary(List<int> list)
        {
            foreach (var item in list)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else dict.Add(item, 1);
            }

            var dict2 = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return dict2;
        }
    }
}
