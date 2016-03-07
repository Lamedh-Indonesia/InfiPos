using InfiPos.Core;
using InfiPos.Core.Products;
using InfiPos.Infras.Data.EFRepos;
using System.Web.Http;

namespace InfiPos.UI.Web.WebApiPos.Controllers
{
    public class ProductController : ApiController
    {
        private ProductService service = new ProductService(new ProductEFRepo());
        
        public IHttpActionResult Get(int page = 0, int size = 3)
        {
            try { return Ok(service.GetAll(page, size)); }
            catch { return InternalServerError(); }
        }

        public IHttpActionResult Get(int id)
        {
            var product = (id == 0)? service.CreateNew() : this.service.GetById(id);
            return product == null ? (IHttpActionResult)NotFound() : Ok(product);
        }

        public IHttpActionResult Post(Product product)
        {
            service.Save(product);
            return Created("/api/product/" + product.Id, product);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
