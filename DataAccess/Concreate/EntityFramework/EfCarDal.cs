using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, EfContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (EfContext context = new EfContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.BrandId
                    join col in context.Colors
                        on c.ColorId equals col.ColorId
                    select new CarDetailsDto
                    {
                        CarName = c.Description,
                        BrandName = b.BrandName,
                        ColorName = col.ColorName,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}
