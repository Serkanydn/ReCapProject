using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager()
        {
        }

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
           
            var result = (_rentalDal.GetAll(r => r.ReturnDate == null));
            if (result.Count > 0)
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Eklendi.");

            }
                
            else
                return new ErrorResult("Eklenemedi");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Silindi.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll()); ;
        }

        

        public IResult Update(Rental rental)
        {
             _rentalDal.Update(rental);
            return new SuccessResult("Güncellendi.");
        }
    }
}
