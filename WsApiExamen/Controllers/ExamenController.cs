using Microsoft.AspNetCore.Mvc;
using WsApiExamen.Contract;
using WsApiExamen.DataAccess;
using WsApiExamen.Dto;
using WsApiExamen.Entities;

namespace WsApiExamen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamenController:ControllerBase
    {
        private readonly IExamenRepository repository;

        public ExamenController(IExamenRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public async Task<ActionResult<List<Examen>>> GetAllExamen([FromQuery]Examen req)
        {
            var result = await repository.GetExamen(req.Id, req.Descripcion, req.Descripcion);
            return Ok(result);
        }



        [HttpPost("/Insert")]
        public async Task<ActionResult<ExamenDto>> InsertExamen([FromBody]Examen examen)
        {
            var result = await repository.InsertExamen(examen);
            return Ok(result);
        }


        [HttpPut("/Update")]
        public async Task<ActionResult<ExamenDto>> UpdateExamen([FromBody]Examen req)
        {
            var result = await repository.UpdateExamen(req.Id, req.Descripcion, req.Descripcion);
            return Ok(result);
        }



        [HttpDelete("/Delete/{id}")]
        public async Task<ActionResult<ExamenDto>> DeleteExamen(int id)
        {
            var result = await repository.DeleteExamen(id);
            return Ok(result);
        }


    }
}
