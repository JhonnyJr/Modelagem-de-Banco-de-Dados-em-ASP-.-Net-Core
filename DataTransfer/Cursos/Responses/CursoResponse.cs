using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Cursos.Responses
{
    public class CursoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ementa { get; set; }
        public int Cargahoraria { get; set; }
        public int Trilha_Id { get; set; }
    }
}
