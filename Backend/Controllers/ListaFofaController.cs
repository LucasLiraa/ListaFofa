using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc; 

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaFofaController : ControllerBase
    {
        Business.ListaFofaBusiness business = new Business.ListaFofaBusiness();
        Utils.ListaFofaConversor conversor = new Utils.ListaFofaConversor();

        [HttpPost]
        public ActionResult<Models.Response.ListaFofaResponse> Inserir (Models.Request.ListaFofaRequest request)
        {
            try
            {
                Models.TbListaFofa lf = conversor.ParaTabela(request);
                business.Salvar(lf);

                Models.Response.ListaFofaResponse resp = conversor.ParaResponse(lf);
                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );

            }
        }

        [HttpGet]
        public ActionResult<List<Models.Response.ListaFofaResponse>> Listar()
        {
            try
            {
                List<Models.TbListaFofa> lfs = business.Listar();
                if (lfs.Count == 0)
                    return NotFound();

                List<Models.Response.ListaFofaResponse> resp = conversor.ParaResponse(lfs);
                return resp;
            }
            catch(Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(500, ex.Message)
                );   
            }
            
        }
    }
}