using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_CRUD.FactoryServices
{
    public interface IFactory
    {
        public void GetAllProduct()
        {
        }
        public void AddProduct(string ProductName, string ProductDetails)
        {
        }
        public void UpdateProduct(int ProductID, string ProductName, string ProductDetails)
        {
        }
        public void DeleteProduct(int ProductID) 
        { 
        }
    }
}
