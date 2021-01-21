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
            ManageDb.Add200PersonsToDB();
            QueryDb.GetPersonsYoungest();
            QueryDb.GetPersonsOldest();
            QueryDb.GetPersonMagicAge();
            QueryDb.GetPersonsShortestName();
            QueryDb.GetPersonLongestName();

            Console.WriteLine("Procedūros atliktos");
            Console.ReadLine();
        }
    }
}
