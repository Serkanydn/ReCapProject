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
    //Class that runs the car's operations conditionally
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal inMemoryCarData)
        {
            _carDal = inMemoryCarData;
        }

        public IResult Add(Car car)
        {
           
                _carDal.Add(car);
                return new SuccessResult("Eklendi.");


            
               
        }

        public IResult Delete(Car car)
        {
            if (car.Description.Length <= 2 || car.DailyPrice <= 0)
            {

                return new ErrorResult("Lütfen Günlük ücreti ya da ürün açıklamasını düzeltin.");
            }

            else
            {
                _carDal.Delete(car);
                return new SuccessResult("Silindi.");

            }
           
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Listelendi.");
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Car car)
        {
            if (car.Description.Length <= 2 || car.DailyPrice <= 0)
            {

                return new ErrorResult("Lütfen Günlük ücreti ya da ürün açıklamasını düzeltin.");
            }

            else
            {
                _carDal.Update(car);
                return new SuccessResult("Güncellendi.");

            }

        }
        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
           return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }
    }
}
