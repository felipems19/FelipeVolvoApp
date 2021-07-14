using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using felipe_santos_volvoapp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace felipe_santos_volvoapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSController : Controller
    {
        ICaminhaoRepository _caminhaoRepository;
        public CSController(ICaminhaoRepository caminhaoRepository)
        {
            _caminhaoRepository = caminhaoRepository;
        }
        /// <summary>
        ///  Get All Messages
        /// </summary>
        /// <remarks>
        ///  GetCaminhoes te permitirá visualizar
        ///  caminhões cadastrados
        /// </remarks>
        [HttpGet("visualizarCaminhoes")]
        public async Task<ActionResult> GetCaminhoes()
        {
            try
            {
                var caminhoes = await _caminhaoRepository.GetCaminhoes();
                if (caminhoes == null)
                {
                    return NotFound();
                }

                return Ok(caminhoes);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}