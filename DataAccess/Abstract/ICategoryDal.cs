using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
        
    }
}
