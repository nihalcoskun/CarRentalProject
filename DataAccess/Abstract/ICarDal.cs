using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    //Car ile ilgili veritabanında yapacağım operasyonları içeren interface.
    {
        List<CarDetailDto> GetCarDetails();
       
       
    }
}
