using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private static ProductService _instance;
        public static ProductService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductService();
                }
                return _instance;
            }
        }

        //1a:Skapa en endpoint som listar alla produkters namn och antal i lager.
        //Listan ska vara sorterad på antal i lager med lägst värde först.
        //Mappa endpoint:en mot /products/count.  

        public List<Product> ProductByNameAndNuminStore() //method
        {
            using (var context = new GroceryContext())        //  Perform data access using the context
            {
                List<Product> NewProductList = new List<Product>();  //new list
                List<Product> SortedProductList = context.Products.OrderBy(Product => Product.NuminStore)/*.ThenBy(Product => Product.ProductName)*/.ToList();
                //SortedProductList.MinBy(p => p.NuminStore);
                //SortedProductList.OrderBy(o => o.NuminStore);

                foreach (Product product in SortedProductList)
                {
                    NewProductList.Add(
                                new Product()
                                {
                                    ProductName = product.ProductName,
                                    NuminStore = product.NuminStore
                                }
                    );
                }
                         return SortedProductList;

            }
            
        }


            //1b:Skapa en endpoint som uppdaterar antalet produkter kvar i butiken för en viss produkt.
            //Mappa endpoint:en mot /products/update.
            //Endpoint:en ska ta emot ett request-objekt som innehåller information om vilken produkt som ska uppdateras som det nya antalet för den produkten.
            //Exempel på request-objekt:
            // {”ProductId”: 13, 
            //”NewCount”: 100 }

            public void UpdateNumInStore(int productId, int newCount)
            {
                using (var context = new GroceryContext())
                {
                    context.Products
                        .FirstOrDefault(p => p.ProductId == productId)
                        .NuminStore = newCount;
                    context.SaveChanges();


                }
            }
        
    }
}
