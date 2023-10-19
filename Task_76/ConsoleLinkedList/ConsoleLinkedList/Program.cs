var ints = new LinkedList<int>(new int[] {  2, 3, 4, 5, 6, 7 });

ints.AddBefore(ints.First, 1); 
ints.AddFirst(0);
ints.AddLast(8);
//ints.Clear();
ints.Remove(ints.First);
ints.RemoveFirst();
ints.RemoveLast();

var node = ints.First; // ints.Last;
while (node != null)
{
    Console.Write(node.Value + " ");
    node = node.Next; // node.Previous;
}
Console.ReadLine();