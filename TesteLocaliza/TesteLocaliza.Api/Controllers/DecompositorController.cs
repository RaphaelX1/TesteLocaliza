using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLocaliza.Comum;
using TesteLocaliza.Interfaces;
using TesteLocaliza.Servicos;

namespace TesteLocaliza.Api.Controllers
{
    [ApiController]

    public class DecompositorController : ControllerBase
    {
        private readonly IDecompositorServico _decompositorServico; 
        public DecompositorController(IDecompositorServico decompositorServico)
        {
            _decompositorServico = decompositorServico;
        }


        /// <summary>
        /// Obtém lista de divisores possíveis e seus divisores primos.
        /// </summary>
        /// <param name="entrada">valor de texto a ser processado</param>
        /// <returns>Lista de divisores possíveis e seus divisores primos ou mensagens de validação</returns>
        [HttpGet]
        [Route("v1/decompositor/divisores-e-primos")]
        [SwaggerOperation(OperationId = "24ef3edb-e0eb-42ca-b73a-7b2ba5be0b3b")]
        public IActionResult Obter(string entrada)
        {
            try
            {
                var resultado = _decompositorServico.DecomporValores(entrada);
                return Ok(resultado);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}
