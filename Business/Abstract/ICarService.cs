using Core.Utilities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Car Manager abstract operation
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<Car> GetCarByCarId(int id);
       // IDataResult<List<Car>> GetByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarByBrandId(int id);
        // IDataResult<List<Car>> GetByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<List<CarDetailDto>> GetCarDetailsCarById(int CarId);
        IDataResult<List<CarDetailDto>> GetCarByBrandAndColorId(int brandId, int colorId);
    }
}
