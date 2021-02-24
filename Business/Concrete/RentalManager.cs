using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            RentalDetailDto rentalDetailDto;
            rentalDetailDto = _rentalDal.GetRentalDetailsByCarId(rental.CarId);
            if (rentalDetailDto == null)
            {
                var result = _rentalDal.GetRentalDetailsByCarId(rental.CarId); ;

                _rentalDal.Add(rental);
                return new SuccessResult("Kiralandı.");
            }
            return new ErrorResult("Kiralanamadı.");
           
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Silindi.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll()); 
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetailDtos());
        }

        public IDataResult<RentalDetailDto> GetRentalDetailsByCarId(int id)
        {
            return new SuccessDataResult<RentalDetailDto>(_rentalDal.GetRentalDetailsByCarId(id));;
        }

        public IResult Update(Rental rental)
        {
            RentalDetailDto rentalDetailDto = _rentalDal.GetRentalDetailsByCarId(rental.CarId);
            rental.CarId = rentalDetailDto.CarId;
            rental.CustomerId = rentalDetailDto.CustomerId;
            rental.RentDate = rentalDetailDto.RentDate;
            rental.ReturnDate = DateTime.Now;
            rental.RentalId = rentalDetailDto.RentalId;

            _rentalDal.Update(rental);
            return new SuccessResult("Eklendi.");
        }
    }
}
