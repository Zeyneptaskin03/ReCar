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
            _cars = new List<Car>
            {/*
                new Car{CarId=1, BrandName="coursa", ColorName="1 beyaz", ModelYear=2020, DailyPrice=220, Description="Opel  3.5 Önden Çekişli"},
                new Car{CarId=2, BrandName="01", ColorName="3 siyah", ModelYear=2018, DailyPrice=600, Description="BMW  2.0 Düz Vites"},
                new Car{CarId=3, BrandName="Megan", ColorName="3 siyah", ModelYear=2021, DailyPrice=100, Description="Renault  1.5 Manuel"},
                new Car{CarId=4, BrandName="midi", ColorName="4 gri", ModelYear=2006, DailyPrice=460, Description="Mini Couper 1.5 Düz Vites"},
                new Car{CarId=5, BrandName="A3", ColorName="2 mavi", ModelYear=2018, DailyPrice=440, Description="Audi  2.6 Arkadan Çekişli"}
            */
            };
        }
        public void Add(Car car)
        {
            {
                _cars.Add(car);
            }
         
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetCarsByBrandName(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetCarsByColorName(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }
    }
}
