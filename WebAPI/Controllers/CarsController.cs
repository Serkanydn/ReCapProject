using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
            
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add( car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }
        [HttpGet("getcardetaildtos")]
        public IActionResult GetCarDetailDtos()
        {
            var result = _carService.GetCarDetailDtos();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("getcardetailsbycarid")]
        public IActionResult GetCarDetailsCarById(int carId)
        {
            var result = _carService.GetCarDetailsCarById(carId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcarbycarid")]
        public IActionResult GetCarByCarId(int carId)
        {
            var result = _carService.GetCarByCarId(carId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbybrand")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _carService.GetCarByBrandId(brandId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbycolor")]
        public IActionResult GetByColor(int colorId)
        {
            var result = _carService.GetCarByColorId(colorId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getbybrandandcolor")]
        public IActionResult GetByBrandAndColorId(int brandId, int colorId)
        {
            var result = _carService.GetCarByBrandAndColorId(brandId, colorId);
               if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
