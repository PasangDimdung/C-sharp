using System;
using System.Threading;

namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            var number = new Nullable<int>(20);
            Console.WriteLine("has value? : " + number.HasValue);
            Console.WriteLine("value: " + number.GetValueOrDefault());
        }
    }

    //where T: struct is generic constraints
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
                
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            return default(T);
        }


    }
}
