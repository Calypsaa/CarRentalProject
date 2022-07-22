using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car {BrandId = 1, CarId = 1, ColorId = 1, DailyPrice = 200, Description = "Sorunsuz kiralık araba",ModelYear = "2007"},
                new Car {BrandId = 1, CarId = 2, ColorId = 1, DailyPrice = 320, Description = "Sorunsuz kiralık araba",ModelYear = "2010"},
                new Car {BrandId = 1, CarId = 3, ColorId = 2, DailyPrice = 180, Description = "Sorunsuz kiralık araba",ModelYear = "2005"},
                new Car {BrandId = 2, CarId = 4, ColorId = 2, DailyPrice = 250, Description = "Sorunsuz kiralık araba",ModelYear = "2009"},
                new Car {BrandId = 2, CarId = 5, ColorId = 3, DailyPrice = 350, Description = "Sorunsuz kiralık araba",ModelYear = "2015"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.BrandId = car.BrandId;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
