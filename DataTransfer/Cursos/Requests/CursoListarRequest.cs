using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Cursos.Requests
{
    public class CursoListarRequest
    {
        public string Nome { get; set; }
        public string Ementa { get; set; }
        public int Cargahoraria { get; set; }
    }
}
