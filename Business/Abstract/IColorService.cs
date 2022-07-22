using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilites.Results;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IResult Delete(Color color);
        IDataResult<Color> Get();
        IResult Update(Color color);
    }
}
