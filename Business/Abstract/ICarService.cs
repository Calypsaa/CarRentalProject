using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilites.Results;
using Entities.Concreate;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult Add(Car car);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IResult Delete(Car car);
        IDataResult<Car> Get();
        IResult Update(Car car);
        
    }
}
