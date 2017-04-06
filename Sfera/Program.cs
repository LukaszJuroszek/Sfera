using Sfera.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    NazwaTechniczna = "SI",
                    Parkingi = new List<Parking>
                    {
                        new Parking {LiczbaMiejscParkingowych=1 },
                        new Parking {LiczbaMiejscParkingowych=2 },
                        new Parking {LiczbaMiejscParkingowych=3 }
                    },
                    Poziomy = new List<Poziom>
                    {
                        new Poziom { PowierzchniaCalkowita = 1000.0,
                            Korytarze = new List<Korytarz>
                            {
                            }
                        }
                    }

                });
            }
        }
    }
}
