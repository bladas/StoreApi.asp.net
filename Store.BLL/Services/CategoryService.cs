using AutoMapper;
using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Services
{
    public class CategoryService:ICategoryService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<OperationDetails> AddCategoryAsync(CategoryDTO category)
        {
            var x = _mapper.Map<CategoryDTO, Category>(category);
           
            try
            {
                await _unitOfWork.CategoryRepository.AddAsync(x);
            }
            catch (Exception ex)
            {
                return new OperationDetails(false, ex.Message, "Error");
            }

            return new OperationDetails(true, "Category has been added", "");
        }
        

        public async Task DeleteCategoryAsync(int id)
        {
            await _unitOfWork.CategoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            var x = await _unitOfWork.CategoryRepository.GetAllAsync();
            List<CategoryDTO> result = new List<CategoryDTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Category, CategoryDTO>(element));
            return result;
        }

        public async Task<object> GetCategoryByIdAsync(int Id)
        {
            return await _unitOfWork.CategoryRepository.GetCategoryDetailsByIdAsync(Id);
        }

        public async Task UpdateCategoryAsync(CategoryDTO carType)
        {
            var x = _mapper.Map<CategoryDTO, Category>(carType);
            await _unitOfWork.CategoryRepository.UpdateAsync(x);
        }
    }
}
