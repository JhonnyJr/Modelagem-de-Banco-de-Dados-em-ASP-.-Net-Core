using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Cursos.Requests
{
    public class CursoInserirRequest
    {
        public string Nome { get; set; }
        public string Ementa { get; set; }
        public int Cargahoraria { get; set; }
        public int Trilha_Id { get; set; }
    }
}
