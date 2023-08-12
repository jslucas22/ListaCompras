using ListaCompras.Domain.Models.Items;
using ListaComrpas.Business.Services.Abstractions.Items;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ListaCompras.Controllers.Items
{
    [ApiController]
    [Route("items/cart")]
    public class ItemsCartController : ControllerBase
    {
        #region ..:: Variables ::..

        private readonly IItemCartService _service;

        #endregion

        #region ..:: Constructor ::..

        public ItemsCartController(IItemCartService service)
        {
            _service = service;
        }

        #endregion

        #region ..:: Methods  ::..

        [HttpPost]
        [Route("create")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> CreateAsync(ItemsCartRequest model)
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
        public async Task<ActionResult<dynamic>> EditAsync(ItemsCartRequest model)
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
        public async Task<ActionResult<ItemsCartResponse>> GetAsync(string id_user, string id_cart)
        {
            try
            {
                await _service.GetAsync(id_user, id_cart);

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
        public async Task<ActionResult<ItemsCartResponse>> GetAllActiveAsync(string id_user)
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
        public async Task<ActionResult<ItemsCartResponse>> GetAllInactiveAsync(string id_user)
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

        [HttpDelete]
        [Route("hardDelete")]
        [AllowAnonymous]
        public async Task<ActionResult<ItemsCartResponse>> DeleteAsync(string id_user, string id_cart)
        {
            try
            {
                await _service.DeleteAsync(id_user, id_cart);

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
