using _20210120_Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210121_EntityFramework.Database
{
    public class ManageDb
    {
        public static void AddPerson (string firstName, string lastName, int age )

        {
           using( var context = new MokymaiContext())
            {
                var person = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                };
                context.Persons.Add(person);
                context.SaveChanges();
            }

        }

        public static void GetPersons()
        {
            using (var ctx = new MokymaiContext())
            {
                var persons = ctx.Persons.Where(p => p.Age < 30);

                foreach (var person in persons)
                {
                    Console.WriteLine("{0}", person.LastName);
                }

            }
        }
    }
}
