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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal entityFramework)
        {
            _userDal = entityFramework;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
           return new SuccessResult("Eklendi.");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Silindi.");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"Listelendi."); 
        }


      

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Güncellendi.");
        }
    }
}
