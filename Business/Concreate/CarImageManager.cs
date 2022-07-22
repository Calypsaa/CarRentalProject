using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concreate;

namespace Business.Concreate
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        ICarService _carService;

        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }

        public IResult Add(CarImage carImage)
        {
            carImage.DateOfUpload = DateTime.Now;
            _carImageDal.Add(carImage);
            SaveToFile(carImage.ImagePath);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetByCar(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        private void SaveToFile(string imagePath)
        {
            string file = "C:\\Folder\\File.txt";
            FileStream stream = File.Create(file);
            StreamWriter sw = new StreamWriter(stream);
        }

        private IResult CheckIfCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result <= 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        private void CheckIfCarImageNull(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result == 0)
            {
                List<CarImage> carImage = new List<CarImage>();
                carImage.Add(new CarImage { CarId = carId, DateOfUpload = DateTime.Now, ImagePath = "default.jpg" });
            }
        }
    }
}
