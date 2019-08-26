using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Students = new Dictionary<int, string>();

            Students.Add(1234567, "Evan Owens");
            
            if(Students.ContainsKey(1234567))
            {
                Console.WriteLine($"{1234567} already exists");
                Students[1234567] = "Katie";
            }
            else
            {
                Console.WriteLine("Key doesn't exist");
            }
            Console.WriteLine(Students[1234567]);
            Console.ReadKey();
        }
    }
}
