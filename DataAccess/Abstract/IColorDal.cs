﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}