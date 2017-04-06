using Sfera.Model;
using System;
using System.Collections.Generic;

namespace Sfera
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataPath = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", dataPath);
            using (var db = new SferaContext())
            {
                db.Database.Log = Console.WriteLine;
                db.Database.CreateIfNotExists();

                db.Obiekty.Add(new Obiekt
                {
                    Nazwa = "SferaI",
                    NazwaTechniczna = "SI"
                });
                db.SaveChanges();
            }
        }
    }
}
