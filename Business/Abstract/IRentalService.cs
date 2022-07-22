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
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalByCarId(int carId);
        IDataResult<List<Rental>> GetRentalByCustomerId(int customerId);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<Rental> Get();
        IResult Update(Rental rental);
    }
}
