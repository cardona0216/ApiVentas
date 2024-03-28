using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SistemaVenta.BLL.Servicios.Contrato;
using SistemaVenta.DTO;
using SistemaVenta.API.Utilidad;

namespace SistemaVenta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        [Route("lista")]
        public async Task<IActionResult> lista(int idUsuario)
        {
            var rsp = new Response<List<MenuDTO>>();

            try
            {
                rsp.status = true;
                rsp.value = await _menuService.Lista(idUsuario);
            }
            catch (Exception ex)
            {
                rsp.status = false;
                rsp.msg = ex.Message;
            }

            return Ok(rsp);
        }
    }
}
