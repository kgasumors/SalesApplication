using BusinessLogic;
using BusinessLogic.Model;
using Microsoft.AspNetCore.Mvc;

namespace SalesApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly SuppliersBL _businessLogic;

        public SuppliersController()
        {
            _businessLogic = new BusinessLogic.SuppliersBL();
        }

        [HttpGet]
        [Route("getSuppliers")]
        public List<SupplierModel> GetSuppliers()
        {
            return _businessLogic.GetSuppliers().ToList();
        }

        [HttpGet]
        [Route("getSupplier")]
        public ActionResult<SupplierModel> GetSupplierById(int id)
        {
            var supplier = _businessLogic.GetSupplierById(id);

            if (supplier is null)
            {
                return NotFound("ID not found/Invalid id");
            }

            return supplier;
        }

        [HttpPost]
        [Route("createPerson")]
        public void createSupplier([FromBody] SupplierModel supplierModel)
        {
            _businessLogic.createSupplier(supplierModel);
        }
    }
}
