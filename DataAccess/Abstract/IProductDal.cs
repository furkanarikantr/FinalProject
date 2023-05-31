using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Dal => Data Access Layer
    public interface IProductDal
    {
        List<Product> GetAll();

        //Kendim Ekledim.
        Product GetProductById(int id); 

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GellAllByCategory(int categoryId);
    }
}
