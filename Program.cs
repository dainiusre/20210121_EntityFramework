using _20210121_EntityFramework.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210121_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageDb.AddPerson("Petras", "Petraitis", 20);
            Console.WriteLine("SQL pvz");
            Console.ReadLine();
        }


        public static void UpdatePersonsAge()
        {

            //using(var ctx = new MokymaiContext()
            //{
            //    var persons = ctx.Persons.Where(p => )
            //}


        }
    }
}
