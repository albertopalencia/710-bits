using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Feautures.Editorial.Queries.GetAllProducto;
using Application.Feautures.Producto.Commands.CreateProductoCommand;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductoController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllProductoQuery()));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductoCommand command)
        {
            return Ok( await Mediator.Send(command));
        }
    }
}