using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş Kodlarındaki Koşulları Sağlanıyorsa DataAccess İşlemlerine Geçebiliriz. Yetkisi Var mı ? gibi.
            return _productDal.GetAll();
        }

        //Kendim Ekledim.
        public Product GetProductById(int id)
        {
            return _productDal.GetProductById(id);
        }
    }
}
