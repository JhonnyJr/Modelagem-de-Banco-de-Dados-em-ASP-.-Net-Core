using DataTransfer.Cursos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Trilhas.Responses
{
    public class TrilhaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Datacriacao { get; set; }
        public IList<CursoResponse> Cursos { get; set; }
    }
}
