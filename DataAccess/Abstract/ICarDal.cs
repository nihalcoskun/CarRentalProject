using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    //Car ile ilgili veritabanında yapacağım operasyonları içeren interface.
    {

        List<Car> GetAll();
        void Add(Car car);
        void UpDate(Car car);
        void Delete(Car car);

        List<Car> GetById(int Id);
    }
}
