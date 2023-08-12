using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = _categoryDal.GetAll();

            if (result != null && result.Count > 0)
            {
                return new SuccessDataResult<List<Category>>(result, "Kategoriler getirildi.");
            }
            return new ErrorDataResult<List<Category>>("Kategori bulunamadı.");
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            var result = _categoryDal.Get(c => c.CategoryId == categoryId);
            if (result != null)
            {
                return new SuccessDataResult<Category>(result, "Kategori getirildi.");
            }
            return new ErrorDataResult<Category>("Kategori bulunamadı.");
        }
    }
}
