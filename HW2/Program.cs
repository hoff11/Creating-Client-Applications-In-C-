using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_and_more_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Models.User> people = Models.ListManager.LoadData();
            Console.WriteLine("Original List");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Password}");
            }
            Console.WriteLine();

            people = people.Where(x => x.Password == "hello").ToList();
            Console.WriteLine("List items where password is equal to \"Hello\"");
            foreach (var person in people)
            {                
                Console.WriteLine($"{person.Name} {person.Password}");
            }
            Console.WriteLine();

            Console.WriteLine("Remaining users after deleting items where password is lower case version of Name");
            people.RemoveAll(x => x.Password == x.Name.ToLower());
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Password}");
            }
            Console.WriteLine();

            var first = people.Where(x => x.Password == "hello").First();
            people.Remove(first);
            Console.WriteLine("Remaining users after also deleting first user with \"hello\" as password.");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Password}");
            }
            Console.ReadKey();
        }
    }
}
