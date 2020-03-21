using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_EFF
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new PC() { CoolingType = "Liquid", Description = "Gaming PC" });
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Computers.Add(new PC() { CoolingType = "Solid", Description = "Office PC" });
            tpt.Computers.Add(new Laptop() { Description = "Personal Laptop", Manufacturer = "DELL", Weight = 7 });

            var tpc = new TPCContext();
            tpt.Computers.Add(new PC() { CoolingType = "Solid", Description = "Office PC" });
            tpt.Computers.Add(new Laptop() { Description = "Personal Laptop", Manufacturer = "DELL", Weight = 7 });

            Console.WriteLine("Ready!");
            Console.ReadLine();
        }
    }
}
