using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set {
                if(value == null)
                {
                    throw new NullReferenceException("Name cannot be null");
                }
                   
                name = value;
            }
        }

    }
    class PersonException : Exception
    {
        public PersonException(String name)
        {
            Name = name;
        }
        public String Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new PersonException("Kim");
                throw new PersonException("Bob");
            }
            catch (PersonException p)
            {
                if (p.Name == "Kim") Console.WriteLine("Ignore Kim");
                if (p.Name == "Bob") Console.WriteLine("It's bob, log it");
            }
            try
            {
                //var person = new Person();
                //person.Name = null;
                throw new Exception("Unable to connect to database");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Disconnecting database");
            }
        }
    }
}
