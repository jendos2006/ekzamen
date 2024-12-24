using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hobby> hobbies = new List<Hobby>();
            hobbies.Add(new Hobby("футбол", "забивать мяч в ворота"));
            hobbies.Add(new Hobby("книги", "читать разные книги"));
            hobbies.Add(new Hobby("воллейбол", "бить мяч рукой"));

            Person person = new Person("Иванов Евгений", "Троицкая 11", hobbies);

            person.ShowAll();
            Console.ReadLine();
        }
    }
}
