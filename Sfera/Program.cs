using Sfera.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

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
                Add(db);
            }

        }
        public static void Add(SferaContext context)
        {
            using (var db = context)
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
                     { Nazwa ="Biedronka",TypDzialalnosci=TypDzialalnosci.Gastronomia,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100},
                     new Pomieszczenie
                     {Nazwa ="McDonald",TypDzialalnosci=TypDzialalnosci.Gastronomia,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100},
                     new Pomieszczenie
                     {Nazwa ="EuroRTV",TypDzialalnosci=TypDzialalnosci.AGD,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100},
                     new Pomieszczenie
                      {Nazwa ="Helios",TypDzialalnosci=TypDzialalnosci.Rozrywka,DataPoczatkuWynajmu=DateTime.Now,CenaWynajmu=100}
                     },
                    Standy = new List<Stand>{
                            new Stand { Nazwa= "Reklama EuroRTV"},
                            new Stand { Nazwa= "Reklama Helios"},
                            new Stand { Nazwa= "Reklama Biedronka"},
                            new Stand { Nazwa= "Reklama McDonald"}
                    }
                };

                var poziomy = new List<Poziom>
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
                Console.Read();
            }
        }
    }
}
