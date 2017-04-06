using Sfera.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
                db.Database.CreateIfNotExists();
                //Add(db);
                var poms = from pom in db.Pomieszczenia
                          where pom.TypPomieszczenia == TypPomieszczenia.Pomieszczenie 
                          select pom;
                foreach (var item in poms)
                {
                    Console.WriteLine($"{item.Nazwa}  {item.TypPomieszczenia}");

                }
                var standy = from pom in db.Standy
                           where pom.TypPomieszczenia == TypPomieszczenia.Stand
                           select pom;
                foreach (var item in standy)
                {
                    Console.WriteLine($"{item.Nazwa}  {item.TypPomieszczenia}");
                }
                    Console.WriteLine(standy.Count());
            }
        }
        public static void Add(SferaContext db)
        {
            {
                var parkingi = new List<Parking> {
                    new Parking { LiczbaMiejscParkingowych=100,Nazwa="Parking Gora",NazwaTechniczna="PG"},
                    new Parking { LiczbaMiejscParkingowych=100,Nazwa="Parking Dol",NazwaTechniczna="Pd"}
                };
                var obiekty = new ObiektDoWynajecia
                {
                    Pomieszczenia = new List<Pomieszczenie>
                    {
                     new Pomieszczenie
                     { Nazwa ="Biedronka",TypDzialalnosci=TypDzialalnosci.Gastronomia,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100, TypPomieszczenia=TypPomieszczenia.Pomieszczenie},
                     new Pomieszczenie
                     {Nazwa ="McDonald",TypDzialalnosci=TypDzialalnosci.Gastronomia,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100,
                     TypPomieszczenia=TypPomieszczenia.Pomieszczenie},
                     new Pomieszczenie
                     {Nazwa ="EuroRTV",TypDzialalnosci=TypDzialalnosci.AGD,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100,
                     TypPomieszczenia=TypPomieszczenia.Pomieszczenie},
                     new Pomieszczenie
                      {Nazwa ="Helios",TypDzialalnosci=TypDzialalnosci.Rozrywka,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100,
                     TypPomieszczenia=TypPomieszczenia.Pomieszczenie}
                     },
                    Standy = new List<Stand>{
                            new Stand { Nazwa= "Reklama EuroRTV",TypPomieszczenia=TypPomieszczenia.Stand},
                            new Stand { Nazwa= "Reklama Helios",TypPomieszczenia=TypPomieszczenia.Stand},
                            new Stand { Nazwa= "Reklama Biedronka",TypPomieszczenia=TypPomieszczenia.Stand},
                            new Stand { Nazwa= "Reklama McDonald",TypPomieszczenia=TypPomieszczenia.Stand}
                    }
                };
                var poziomy = new List<Poziom>
                        { new Poziom {
                        Nazwa = "Pierwsze",NazwaTechniczna = "P1",PowierzchniaCalkowita = 1000,
                        Korytarze = new List<Korytarz>
                        {
                            new Korytarz
                            {
                                Nazwa ="Korytarz Glowny",NazwaTechniczna="KG",ObiektyDoWynajecia =new List<ObiektDoWynajecia>
                                    {
                                        obiekty,obiekty,obiekty
                                    }
                             },
                         }
                    },
                };
                var poziomy2 = new List<Poziom>
                        {
                    new Poziom
                    {
                        Nazwa = "Pierwsze",NazwaTechniczna = "P1",PowierzchniaCalkowita = 1000,
                        Korytarze = new List<Korytarz>
                        {
                            new Korytarz
                            {
                                Nazwa ="Korytarz Glowny",NazwaTechniczna="KG",ObiektyDoWynajecia =new List<ObiektDoWynajecia>
                                    {
                                        obiekty,obiekty,obiekty
                                    }
                             },
                         }
                    },
                };
                db.Obiekty.Add(new Obiekt
                {
                    Nazwa = "SferaI",
                    NazwaTechniczna = "SI",
                    Parkingi = parkingi,
                    Poziomy = poziomy
                });
                db.Obiekty.Add(new Obiekt
                {
                    Nazwa = "SferaII",
                    NazwaTechniczna = "SII",
                    Poziomy = poziomy2
                });
                db.SaveChanges();
            }
        }
    }
}