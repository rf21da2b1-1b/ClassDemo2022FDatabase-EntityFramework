using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using BilLib.model;

namespace BilDatabaseApp
{
    public class AWorker 
    {
        public AWorker()
        {

        }

        public void Start()
        {
            //DoCar();
            DoCarEF();
        }

        private static void DoCar()
        {
            CarManager mgr = new CarManager();

            Console.WriteLine("Alle biler");
            List<Car> cars = mgr.GetAll();
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Bil med reg nummer DD22334");
            Console.WriteLine(mgr.GetByRegNr("DD22334"));


            // opret bil
            Console.WriteLine("Oprettet bil");
            Car nyBil = new Car("ZZ22334", "Blå", false, "11223344");
            Car c1 = mgr.Create(nyBil);
            Console.WriteLine(c1);
            Console.Write("Tryk return for at fortsætte ");
            Console.ReadLine();

            // modify
            Console.WriteLine("Ændret bil");
            nyBil.Colour = "Meget sort";
            Car c2 = mgr.Modify(nyBil.RegNr, nyBil);
            Console.WriteLine(c2);
            Console.Write("Tryk return for at fortsætte ");
            Console.ReadLine();

            // slet bil
            Console.WriteLine("Slettet bil");
            Car c3 = mgr.Delete(nyBil.RegNr);
            Console.WriteLine(c3);
            Console.Write("Tryk return for at fortsætte ");
            Console.ReadLine();
        }


        private static void DoCarEF()
        {
            CarServiceEF mgr = new CarServiceEF();

            Console.WriteLine("Alle biler");
            List<BilLibEF.model.Car> cars = mgr.GetAll();
            foreach (var c in cars)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Bil med reg nummer DD22334");
            Console.WriteLine(mgr.GetByRegNr("DD22334"));


            // opret bil
            Console.WriteLine("Oprettet bil");
            BilLibEF.model.Car nyBil = new BilLibEF.model.Car("ZZ22334", "Blå", false, "11223344");
            BilLibEF.model.Car c1 = mgr.Create(nyBil);
            Console.WriteLine(c1);
            Console.Write("Tryk return for at fortsætte ");
            Console.ReadLine();

            // modify
            Console.WriteLine("Ændret bil");
            nyBil.Colour = "Meget sort";
            BilLibEF.model.Car c2 = mgr.Modify(nyBil.RegNr, nyBil);
            Console.WriteLine(c2);
            Console.Write("Tryk return for at fortsætte ");
            Console.ReadLine();

            // slet bil
            Console.WriteLine("Slettet bil");
            BilLibEF.model.Car c3 = mgr.Delete(nyBil.RegNr);
            Console.WriteLine(c3);
            Console.Write("Tryk return for at fortsætte ");
            Console.ReadLine();
        }

    }
}