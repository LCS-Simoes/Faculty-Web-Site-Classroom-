using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Usuarios
    {
        //MODEL - PROPRIEDADES DA TABELA USUARIOS
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string NomeAcesso { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }
    }
}