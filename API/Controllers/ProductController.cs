using API.DTO;
using Microsoft.AspNetCore.Mvc;
using Service;


namespace API.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("count")]
        public IActionResult ListProduct()      //Method
        {
            var ProductsDto = new List<ProductDTO>();   // new empty list av DTO properties
            var products = ProductService.Instance.ProductByNameAndNuminStore();   // Instance av service
            try
            {

                foreach (var product in products)
                {
                    ProductsDto.Add(new ProductDTO()
                    {
                        ProductName = product.ProductName,
                        NuminStore = product.NuminStore,

                    });
                }
                return Ok(ProductsDto);

            }
            catch (Exception)
            {
                return BadRequest();

            }

        }
        //[HttpPut("update")]
        //public void UpdateNumInStore(ProductDTO productDTO)
        //{
        //    ProductService.Instance.UpdateNumInStore(productDTO.ProductID, productDTO.NuminStore);
        //}


        [HttpPut("update")]
        public void UpdateNumInStore(UpdateProductDTO updateProductDTO)
        {
            ProductService.Instance.UpdateNumInStore(updateProductDTO.ProductID, updateProductDTO.NuminStore);
        }

    }
}
