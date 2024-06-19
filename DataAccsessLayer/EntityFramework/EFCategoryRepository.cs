﻿using DataAccsessLayer.Abstact;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EFCategoryRepository: GenericRepsitory<Category>, ICategoryDal
    {
    }
}