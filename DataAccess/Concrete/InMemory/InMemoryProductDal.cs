using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Databaseden geliyomus gibi simule ettik
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Glass",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Camera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Phone",UnitPrice=1500,UnitsInStock=5},
                new Product{ProductId=4,CategoryId=2,ProductName="Keyboard",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Mouse",UnitPrice=85,UnitsInStock=1}

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // burada remove la direk silemeyiz cunku referans degerini bulup silmemiz lazim. Burda uniq olan Id degerini kullanarak silmek mantikli
            

            Product productToDelete = null;
            //1.yol olarak LINQ kullanmadan soyle yapabiliriz
            /*foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }*/

            //2.yol LINQ ile

            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);//bu yukardaki foreachin yaptigini yapar

            _products.Remove(productToDelete);

            
        }

        public List<Product> GetAll()
        {
            return _products; //yaniyi databsedeki tum veriyi return ediyorum
        }

        public void Update(Product product)
        {
            //Find the prod Id which i used as parameter
            Product productToUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
