﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfImagesRepository : GenericRepository<Images>, IImagesDal
    {
    }
}
