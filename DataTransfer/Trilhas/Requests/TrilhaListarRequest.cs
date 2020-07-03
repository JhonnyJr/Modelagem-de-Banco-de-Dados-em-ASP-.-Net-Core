using DataTransfer.Cursos.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Trilhas.Requests
{
    public class TrilhaListarRequest
    {
        public string Nome { get; set; }
        public DateTime Date { get; set; }
        public CursoListarRequest cursoListar { get; set; }
    }
}
