﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService : IService<Rental>
    {
        IResult IsReturn(int id);
        IDataResult<RentalDetailDto> GetRentalDto(Expression<Func<Rental, bool>> filter = null);
    }
}