﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void Delete(Category category)
        {
           _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.List();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId==id);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
