using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;

namespace Business.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult("Araba silindi");
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_cardal.Get(c => c.CarId == id));
        }

        public IDataResult<Car> Get()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            _cardal.Update(car);
            return new SuccessResult("Araba güncellendi");
        }

        IResult ICarService.Add(Car car)
        {
            _cardal.Add(car);
            return new SuccessResult("Araba eklendi");
        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll());
        }

        IDataResult<List<CarDetailsDto>> ICarService.GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_cardal.GetCarDetails());
        }

        IDataResult<List<Car>> ICarService.GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.BrandId == id));
        }

        IDataResult<List<Car>> ICarService.GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.ColorId == id));
        }

    }
}
