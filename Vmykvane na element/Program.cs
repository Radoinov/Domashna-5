namespace Vmykvane_na_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> chisla = new LinkedList<int>();
            chisla.AddLast(1);
            chisla.AddLast(2);
            chisla.AddLast(4);
            chisla.AddLast(5);
            Console.WriteLine("Lista predi da dobavq 3:");
            PrintList(chisla);
            LinkedListNode<int> node = chisla.Find(2);
            if (node != null)
            {
                chisla.AddAfter(node, 3);
            }
            Console.WriteLine("Spisaka sled kato dobavih 3:");
            PrintList(chisla);
            IsListSorted(chisla);
        }
        static void PrintList(LinkedList<int> list)
        {
            foreach (var num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void IsListSorted(LinkedList<int> list)
        {


            var current = list.First;
            while (current.Next != null)
            {
                if (current.Value > current.Next.Value)
                {
                    Console.WriteLine("Lista ne e konkretno podreden.");
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Lista e konkretno podreden.");
        }

    }
}
