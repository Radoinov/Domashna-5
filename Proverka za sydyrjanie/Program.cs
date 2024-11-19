namespace Proverka_za_sydyrjanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> imena = new LinkedList<string>();
            imena.AddLast("Ivan");
            imena.AddLast("Gosho");
            imena.AddLast("Mitko");
            imena.AddLast("Teodor");
            foreach (var ime in imena)
            {
                Console.WriteLine(ime + " ");
            }
            string nameToCheck = "John";
            CheckNameInList(imena, nameToCheck);
        }
        static void CheckNameInList(LinkedList<string> list, string name)
        {
            var current = list.First;
            while (current != null)
            {
                if (current.Value == name)
                {
                    Console.WriteLine($"Imeto {name} se sadyrja v lista.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine($"Imeto {name} ne se sadyrja v lista.");
        }
    }
}
