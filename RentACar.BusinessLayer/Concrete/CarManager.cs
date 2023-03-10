using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public void TDelete(Car t)
        {
            _carDal.Delete(t);
        }

        public Car TGetByID(int id)
        {
            return _carDal.GetByID(id);
        }

        public List<Car> TGetList()
        {
            return _carDal.GetList();
        }

        public void TInsert(Car t)
        {
            _carDal.Insert(t);
        }

        public void TUpdate(Car t)
        {
            _carDal.Update(t);
        }
    }
}
