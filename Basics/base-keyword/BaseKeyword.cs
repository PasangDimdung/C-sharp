using System;

namespace BaseKeyword
{
    abstract class Person
    {
        private readonly string _firstname;
        private readonly string _lastname;

        protected Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }
        public string GetFullName()
        {
            return $"{_firstname} {_lastname}";
        }
    }

    class Pasang: Person
    {
        public Pasang(string firstname, string lastname): base(firstname,lastname)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            Person P = new Pasang("Pasang", "Dimdung");
            Console.WriteLine(P.GetFullName());
        }

    }
}
