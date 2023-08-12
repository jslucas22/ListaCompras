using ListaCompras.Domain.Models.Items;
using ListaComrpas.Business.Services.Abstractions.Items;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ListaCompras.Controllers.Items
{
    [ApiController]
    [Route("items/buy")]
    public class ItemsProductController : Controller
    {
        #region ..:: Variables ::..

        private readonly IItemProductService _service;

        #endregion

        #region ..:: Constructor ::..

        public ItemsProductController(IItemProductService service)
        {
            _service = service;
        }

        #endregion

        #region ..:: Methods  ::..

        [HttpPost]
        [Route("create")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> CreateAsync(ItemsProductRequest model)
        {
            try
            {
                await _service.CreateAsync(model);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        [HttpPatch]
        [Route("edit")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> EditAsync(ItemsProductRequest model)
        {
            try
            {
                await _service.EditAsync(model);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        [HttpGet]
        [Route("get")]
        [AllowAnonymous]
        public async Task<ActionResult<ItemsProductResponse>> GetAsync(string id_user, string id_product)
        {
            try
            {
                await _service.GetAsync(id_user, id_product);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        [HttpGet]
        [Route("getActive")]
        [AllowAnonymous]
        public async Task<ActionResult<ItemsProductResponse>> GetAllActiveAsync(string id_user)
        {
            try
            {
                await _service.GetAllActiveAsync(id_user);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        [HttpGet]
        [Route("getInactive")]
        [AllowAnonymous]
        public async Task<ActionResult<ItemsProductResponse>> GetAllInactiveAsync(string id_user)
        {
            try
            {
                await _service.GetAllInactiveAsync(id_user);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        [HttpPut]
        [Route("softDelete")]
        [AllowAnonymous]
        public async Task<ActionResult<ItemsProductResponse>> SoftDeleteAsync(string id_user, string id_product)
        {
            try
            {
                await _service.SoftDeleteAsync(id_user, id_product);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        [HttpDelete]
        [Route("hardDelete")]
        [AllowAnonymous]
        public async Task<ActionResult<ItemsProductResponse>> DeleteAsync(string id_user, string id_product)
        {
            try
            {
                await _service.DeleteAsync(id_user, id_product);

                return Ok();
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        #endregion
    }
}
