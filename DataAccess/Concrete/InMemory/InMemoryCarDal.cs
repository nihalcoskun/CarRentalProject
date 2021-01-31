using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
       
        public InMemoryCarDal()
        {

            _cars = new List<Car> {
              new Car{Id = 156324, BrandId = 12, ColorId = 96, DailyPrice=150000, ModelYear=2010, Description= "Renault Clio" },
              new Car{Id = 132864, BrandId = 5, ColorId = 16, DailyPrice=389000, ModelYear=2012, Description= "BMW 520i" },
              new Car{Id = 951423, BrandId = 11, ColorId = 88, DailyPrice=1350000, ModelYear=2020, Description= "Volco XC90" },
              new Car{Id = 786159, BrandId = 8, ColorId = 52, DailyPrice=200000, ModelYear=2015, Description= "Honda Civic" },
              new Car{Id = 623584, BrandId = 12, ColorId = 34, DailyPrice=350000, ModelYear=2020, Description= "Wolksvagen Passat" },


            };
        }
            public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ Language Integrated Quary
            //Lambda
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {

            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void UpDate(Car car)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
            //Bu şekilde güncelleme yapabilirim
        }
    }
}
