using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        DataResult<List<Category>> GetAll();
        DataResult<List<Category>> GetById(int categoryId);
    }
}
