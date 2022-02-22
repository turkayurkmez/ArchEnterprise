using System;
using System.Collections.Generic;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            * Bir sınıf, bir interface'i implemente ediyorsa, o interface'den gelen bütün metotları kullanmalıdır.
            * 
            */
        }
    }

    public interface IRepository
    {
        void Add();
        void Update();
        void Delete();
        object GetItemById(int id);

      


    }

    public interface IProductRepository : IRepository
    {
        List<object> GetAllProducts();
        List<object> GetProductsByName();
        List<object> GetProductsByPrice();
    }

    public interface ICategoryRepository: IRepository
    {
        object GetCategoryById();
    }

    public class ProductRepository : IProductRepository
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<object> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public object GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetProductsByName()
        {
            throw new NotImplementedException();
        }

        public List<object> GetProductsByPrice()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryRepository : ICategoryRepository
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public object GetCategoryById()
        {
            throw new NotImplementedException();
        }

        public object GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
