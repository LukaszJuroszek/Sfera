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
                var parkingi = new List<Parking> {
                    new Parking { LiczbaMiejscParkingowych=100,Nazwa="Parking Gora",NazwaTechniczna="PG"},
                    new Parking { LiczbaMiejscParkingowych=100,Nazwa="Parking Dol",NazwaTechniczna="Pd"}
                };
                var obiektyDoWynajecia = new List<ObiektDoWynajecia>
                {
                    new ObiektDoWynajecia{
                        Pomieszczenia= new List<Pomieszczenie>
                        {
                            new Pomieszczenie{Nazwa="Biedronka",TypDzialalnosci=TypDzialalnosci.Gastronomia,DataPoczatkuWynajmu=DateTime.Now,,CenaWynajmu=100},
                            new Pomieszczenie{Nazwa="EuroRTV",TypDzialalnosci=TypDzialalnosci.AGD,DataPoczatkuWynajmu=DateTime.Now.AddDays(-93),CenaWynajmu=100},
                            new Pomieszczenie{Nazwa="McDonald",TypDzialalnosci=TypDzialalnosci.AGD,DataPoczatkuWynajmu=DateTime.Now.AddDays(-93),CenaWynajmu=100},
                        },
                        Standy= new List<Stand>{
                            new Stand { Nazwa= "Reklama EuroRTV",CenaWynajmu=10},
                            new Stand { Nazwa= "Reklama McDonald",CenaWynajmu=10},
                        }
                    }
                };
                var korytarze = new List<Korytarz>
                {
                    new Korytarz{Nazwa="Korytarz Glowny",NazwaTechniczna="KG",ObiektyDoWynajecia=obiektyDoWynajecia},
                    new Korytarz{Nazwa="Korytarz Poboczny",NazwaTechniczna="KB",ObiektyDoWynajecia=obiektyDoWynajecia}
                };
                var poziomy = new List<Poziom>
                {
                    new Poziom{Nazwa="Pierwsze",NazwaTechniczna="P1",PowierzchniaCalkowita=1000, Korytarze=korytarze},
                    new Poziom{Nazwa="Drugie",NazwaTechniczna="P2",PowierzchniaCalkowita=1000, Korytarze=korytarze},
                    new Poziom{Nazwa="Trzecie",NazwaTechniczna="P3",PowierzchniaCalkowita=1000, Korytarze=korytarze}
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
                    Nazwa = "Sfera2",
                    NazwaTechniczna = "S2",
                    Parkingi = parkingi,
                    Poziomy = poziomy
                });
                db.SaveChanges();
            }
        }
    }
}
