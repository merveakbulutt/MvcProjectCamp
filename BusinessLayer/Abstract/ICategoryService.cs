using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetById(int id);
    }
}
