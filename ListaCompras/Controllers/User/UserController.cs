using ListaCompras.Domain.Models.Authentication;
using ListaComrpas.Business.Services.Abstractions.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ListaCompras.Controllers.User
{
    [ApiController]
    [Route("auth")]
    public class UserController : ControllerBase
    {
        #region ..:: Variables ::..

        private readonly IUserService _service;

        #endregion

        #region ..:: Constructor ::..

        public UserController(IUserService service)
        {
            _service = service;
        }

        #endregion

        #region ..:: Methods ::..

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login(UserLoginRequest model)
        {
            try
            {
                var user = await _service.Login(model);

                if (user == null)
                {
                    return NotFound();
                }

                //# Tratar tipo de autenticacao

                return Ok(user);
            }
            catch (UnauthorizedAccessException uEx)
            {
                return Unauthorized(new { uEx.Message });
            }
            catch (Exception)
            {
                return Problem("Oopsies Woopsies, something went wrong.");
            }
        }

        #endregion

    }
}
