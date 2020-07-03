using Aplicacao.Cursos.Servicos;
using Aplicacao.Cursos.Servicos.Interfaces;
using DataTransfer.Cursos.Requests;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ICursoAppServico cursoAppServico;
        
        public CursosController(ICursoAppServico cursoAppServico)
        {
            this.cursoAppServico = cursoAppServico;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(cursoAppServico.Listar());
        }

        [HttpPost]  
        public ActionResult Post([FromBody] CursoInserirRequest request)
        {
            return Ok(cursoAppServico.Inserir(request));
        }
        
        [HttpDelete]
        [Route("{codigo:int}")]
        public ActionResult Delete(int codigo)
        {
            cursoAppServico.Deletar(codigo);
            return Ok();  
        }
    }
}
