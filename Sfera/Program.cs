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

            }
        }
    }
}
