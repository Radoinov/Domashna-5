using System;

namespace Prebroqvane_na_elementi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            
            nums.AddLast(10);
            nums.AddLast(20);
            nums.AddLast(30);
            nums.AddLast(40);
            nums.AddLast(50);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            CountElements(nums);
            
        }            
        static void CountElements(LinkedList<int> list)
        {
            int count = 0;
            var current = list.First;

            while (current != null)
            {
                count++;
                current = current.Next;
            }


            Console.WriteLine($"Broq na elementite e: {count}");
        }
        

    }
}
