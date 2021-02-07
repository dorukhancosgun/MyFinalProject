﻿using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   //generic constraint
    //class: 'referance type' anlaminda
    //IEntity veya onu implamente eden bir nesne cagirilabilir. 
    //new(): new'lenebilir olmali(yani IEntitynin kendini cagiramiyoruz.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
