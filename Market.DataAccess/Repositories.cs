using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Entities;
using Market.Service;

namespace Market.DataAccess
{
    public interface IRepositories<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
    public interface ICategoryRepository : IRepositories<Category>
    {
        Task<Category> GetCategoryWithProductsAsync(int id);
    }

    public interface IProductRepository : IRepositories<Product>
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
    }

    public interface ICartRepository : IRepositories<Cart>
    {
        Task<Cart> GetCartWithItemsAsync(int buyerId);
    }

    public interface IBuyerRepository : IRepositories<Buyer>
    {
        Task<Buyer> GetBuyerWithCartAsync(int id);
    }


}