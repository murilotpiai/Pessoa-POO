using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO
{
    public class Usuario : Pessoa
    {   
        //Usuario herda de pessoa
        //Recebe tudo o que estiver publico
        public string Email { get; set; }
        public string Senha { get; set; }

        public string NomeEmail
        {
            get
            {
                return CPFNome + " - " + Email;
            }
        }
    }
}
