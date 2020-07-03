using Aplicacao.Trilhas.Servicos;
using Aplicacao.Trilhas.Servicos.Interfaces;
using DataTransfer.Trilhas.Requests;
using Dominio.Trilhas.Entidades;
using FluentNHibernate.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrilhasController : ControllerBase
    {
        private readonly ITrilhasAppServico trilhaAppServico;

        public TrilhasController(ITrilhasAppServico trilhaAppServico)
        {
            this.trilhaAppServico = trilhaAppServico;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(this.trilhaAppServico.Listar());
        }
        [HttpPost]
        public ActionResult Post([FromBody] TrilhaInserirRequest request)
        {
            return Ok(this.trilhaAppServico.Inserir(request));
        }
        [HttpDelete]
        [Route("{codigo:int}")]
        public ActionResult Deletar(int codigo)
        {
            this.trilhaAppServico.Deletar(codigo);
            return Ok();
        }
    }
}
