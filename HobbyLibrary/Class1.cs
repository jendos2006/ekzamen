﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Иванов Е.
namespace HobbyLibrary
{
    public class Hobby
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Hobby(string n, string d)
        {
            name = n;
            description = d;
        }

        public void Show()
        {
            Console.WriteLine($"{name} - {description}");
        }
    }

    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private List<Hobby> hobbeis = new List<Hobby>();
        public List<Hobby> Hobbies
        {
            get { return hobbeis; }
            set { hobbeis = value; }
        }

        public Person(string n, string a, List<Hobby> h)
        {
            name = n;
            address = a;
            hobbeis = h;
        }

        public void ShowAll()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Хобби:");
            for (int i = 0; i < hobbeis.Count; i++)
            {
                hobbeis[i].Show();
            }
        }
    }
}
