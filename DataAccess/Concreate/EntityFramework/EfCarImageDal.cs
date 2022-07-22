using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, EfContext>, ICarImageDal
    {

    }
}
