using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concreate;

namespace Business.Concreate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("Müşteri eklendi");
        }

        public IResult Delete(Customer customer)
        {
            return new ErrorResult("Müşteri silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetCustomerByUserId(int userId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.UserId == userId));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
