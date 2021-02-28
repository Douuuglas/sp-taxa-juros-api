using Microsoft.AspNetCore.Mvc;

namespace SP.TAXA.JUROS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    /// <summary>
    /// Controller responsável por retornar as taxas de juros
    /// </summary>
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        /// <summary>
        /// Método responsável por retorna a taxa de juros
        /// </summary>
        /// <returns>
        /// Taxa de juros fixa no valor de 1%
        /// </returns>
        public decimal Get()
        {
            return 0.01m;
        }
    }
}
