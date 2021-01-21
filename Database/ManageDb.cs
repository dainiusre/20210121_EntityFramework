using _20210120_Linq.Models;
using System;
using System.Linq;

namespace _20210121_EntityFramework.Database
{
    public class ManageDb
    {

                
        //Sukuriami masyvai po 14 narių ir atsitiktine tvarka užpildoma 200 eilučių duomenų bazė. Amžius taip pat priskiriamas atsitiktine tvarka nuo 8 iki 85 metų.
        public static void Add200PersonsToDB()
        {

            int constPersonsCount = 200;
            int constMinAge = 5;
            int constMaxAge = 85;
            Random rng = new Random();

            string[] firstNames = {"Jonas", "Pranas", "Vardas", "Tomas", "Algis", "Simas", "Vytas", "Vytautas", "Kęstutis", "Dainius", "Darius", "Jonas", "Petras", "Giedrius"};
            string[] lastNames = {"Jonaitis", "Pranaitis", "Pavardenis", "Tomaitis", "Algaitis", "Simaitis", "Vytaitis", "Lapinas", "Vilkas", "Remeikis", "Daraitis", "Antanaitis", "Petraitis", "Giedraitis"};


            using (var context = new MokymaiContext())
            {
                for (int p = 0; p < constPersonsCount; p++)
                {
                var person = new Person
                    {
                        FirstName = firstNames[rng.Next(firstNames.Count())],
                        LastName = lastNames[rng.Next(lastNames.Count())],
                        Age = rng.Next(constMinAge, constMaxAge),
                    };
                    context.Persons.Add(person);
                    
                }  
                context.SaveChanges();
            }
        }

    }

}
