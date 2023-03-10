﻿using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Repositories;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccessLayer.EntityFramework
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        public void CarListByBrand()
        {
            throw new NotImplementedException();
        }
    }
}
