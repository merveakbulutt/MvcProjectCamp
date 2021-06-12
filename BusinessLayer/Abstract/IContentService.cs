﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IContentService
    {
        List<Content> GetAll();
        void Add(Content content);
        void Update(Content content);
        void Delete(Content content);
        List<Content> GetListByHeadingId(int id);
        Content GetById(int id);
    }
}
