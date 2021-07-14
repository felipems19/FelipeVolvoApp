using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace felipe_santos_volvoapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaminhoesController : Controller
    {

        /// <summary>
        ///  Get All Messages
        /// </summary>
        /// <remarks>
        ///  GetCaminhoes te permitirá visualizar
        ///  caminhões cadastrados
        /// </remarks>
        [HttpGet("visualizarCaminhoes")]
        public async Task<ActionResult> GetCaminhoes(int caminhaoId)
        {
            /*
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
             * 
             * 
             * */
            /*
           var books = from b in db.Books
                       select new BookDto()
                       {
                           Id = b.Id,
                           Title = b.Title,
                           AuthorName = b.Author.Name
                       };
           */

            /*
            // GET api/Books/5
[ResponseType(typeof(BookDetailDto))]
public async Task<IHttpActionResult> GetBook(int id)
{
    var book = await db.Books.Include(b => b.Author).Select(b =>
        new BookDetailDto()
        {
            Id = b.Id,
            Title = b.Title,
            Year = b.Year,
            Price = b.Price,
            AuthorName = b.Author.Name,
            Genre = b.Genre
        }).SingleOrDefaultAsync(b => b.Id == id);
    if (book == null)
    {
        return NotFound();
    }

    return Ok(book); 


             * */


            return Ok(HtmlEncoder.Default.Encode($"Hello, caminhaoId is: {caminhaoId}"));
        }
        /*
        [HttpPost]
        public async Task<ActionResult> PostCaminhoes()
        {

        }
        */
    }
}