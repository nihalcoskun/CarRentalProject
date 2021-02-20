using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
       
        public InMemoryCarDal()
        {

            _cars = new List<Car> {
              new Car{CarId = 156324, BrandId = 12, ColorId = 96, DailyPrice=150000, ModelYear=2010, Descriptions= "Renault Clio" },
              new Car{CarId = 132864, BrandId = 5, ColorId = 16, DailyPrice=389000, ModelYear=2012, Descriptions= "BMW 520i" },
              new Car{CarId = 951423, BrandId = 11, ColorId = 88, DailyPrice=1350000, ModelYear=2020, Descriptions= "Volco XC90" },
              new Car{CarId = 786159, BrandId = 8, ColorId = 52, DailyPrice=200000, ModelYear=2015, Descriptions= "Honda Civic" },
              new Car{CarId = 623584, BrandId = 12, ColorId = 34, DailyPrice=350000, ModelYear=2020, Descriptions= "Wolksvagen Passat" },


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
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {

            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void UpDate(Car car)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            
            //Bu şekilde güncelleme yapabilirim
        }
    }
}
