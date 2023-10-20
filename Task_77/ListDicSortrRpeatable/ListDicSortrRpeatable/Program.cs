/*
    * Дан список целых чисел (числа не последовательны), в котором некоторые числа повторяются. 
    * Выведите список чисел на экран, расположив их в порядке возрастания частоты повторения
    * List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
*/

using ListDicSortrRpeatable.Base;

List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };

foreach (var i in GetDictionaryClass.GetDictionary(ints))
    Console.WriteLine(i);

