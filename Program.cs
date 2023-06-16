namespace CustomeLikedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("A");
            list.AddFirst("B");
            list.AddFirst("C");
            list.Display();
            /*Console.WriteLine();
            list.AddLast("z");
            list.Display();
            Console.WriteLine();
            list.DeleteFirst();
            list.Display();*/
        }
    }
}