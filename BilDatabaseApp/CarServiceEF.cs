using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilLibEF.model;

namespace BilDatabaseApp
{
    public class CarServiceEF:IBilServiceEF
    {
        private DemodbContext _db;

        public CarServiceEF()
        {
            _db = new DemodbContext();
        }


        public List<Car> GetAll()
        {
            return _db.Cars.ToList();
        }

        public Car GetByRegNr(string regNr)
        {
            return _db.Cars.Where(c => c.RegNr == regNr).First();
        }

        public Car Create(Car newCar)
        {
            _db.Cars.Add(newCar);
            _db.SaveChanges();

            return newCar;
        }

        public Car Delete(string regNr)
        {
            Car deletedCar = GetByRegNr(regNr);
            _db.Cars.Remove(deletedCar);
            _db.SaveChanges();

            return deletedCar;
        }

        public Car Modify(string regNr, Car modifiedCar)
        {
            _db.Cars.Update(modifiedCar);
            _db.SaveChanges();

            return GetByRegNr(regNr);
        }
    }
}
