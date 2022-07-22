using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concreate;
using Core.Utilites.Results;
using Entities.Concreate;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
