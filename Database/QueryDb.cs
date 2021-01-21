using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210121_EntityFramework.Database
{
    class QueryDb
    {
        //Linq užklausa, randanti TOP5 jauniausius asmenis.
        public static void GetPersonsYoungest()
        {
            Console.WriteLine("TOP5 jauniausi asmenys:");
            using (var context = new MokymaiContext())
            {
                var persons = context.Persons.OrderBy(p => p.Age).Take(5);
                foreach (var person in persons)
                {
                    Console.WriteLine("{0} {1}, {2}", person.FirstName, person.LastName, person.Age);
                }
            }
            Console.WriteLine(Environment.NewLine);
        }

        //Linq užklausa, randanti TOP5 vyriausius asmenis.
        public static void GetPersonsOldest()
        {
            Console.WriteLine("TOP5 vyriausi asmenys:");
            using (var context = new MokymaiContext())
            {
                var persons = context.Persons.OrderByDescending(p => p.Age).Take(5);
                foreach (var person in persons)
                {
                    Console.WriteLine("{0} {1}, {2}", person.FirstName, person.LastName, person.Age);
                }

            }
            Console.WriteLine(Environment.NewLine);
        }

        //Linq užklausa, randanti asmenis, kurių amžius dalijasi ir iš 2, ir iš 3. AND operandas.
        public static void GetPersonMagicAge()
        {
            Console.WriteLine("Asmenys, kurių amžius dalijasi iš 2, ir iš 3:");
            using (var context = new MokymaiContext())
            {
                var persons = context.Persons.Where(p => (p.Age % 2 == 0 && p.Age % 3 == 0));
                foreach (var person in persons)
                {
                    Console.WriteLine("{0} {1}, {2}", person.FirstName, person.LastName, person.Age);
                }

            }
            Console.WriteLine(Environment.NewLine);
        }

        //Linq užklausa, randanti TOP5 trumpiausiais vardais asmenis.
        public static void GetPersonsShortestName()
        {
            Console.WriteLine("TOP5 trumpiausiais vardais asmenys:");
            using (var context = new MokymaiContext())
            {
                var persons = context.Persons.OrderBy(p => p.FirstName.Length).Take(5);
                foreach (var person in persons)
                {
                    Console.WriteLine("{0} {1}, {2}", person.FirstName, person.LastName, person.Age);
                }
            }
            Console.WriteLine(Environment.NewLine);
        }

        //Linq užklausa, randanti TOP5 ilgiausiais vardais asmenis.
        public static void GetPersonLongestName()
        {
            Console.WriteLine("TOP5 ilgiausiais vardais asmenys:");
            using (var context = new MokymaiContext())
            {
                var persons = context.Persons.OrderByDescending(p => p.FirstName.Length).Take(5);
                foreach (var person in persons)
                {
                    Console.WriteLine("{0} {1}, {2}", person.FirstName, person.LastName, person.Age);
                }

            }
            Console.WriteLine(Environment.NewLine);
        }




    }
}
