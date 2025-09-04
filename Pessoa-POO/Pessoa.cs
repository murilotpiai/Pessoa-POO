using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO
{
    public class Pessoa
    {
        //Criar os atributos (propriedades)
        //digite prop e aperte TAB
        
        //Serão leitura e gravação 
        public string Nome { get; set; }

        public string CPF { get; set; }

        public DateTime DtNascimento { get; set; }

        //Propriedades somente leitura 

        public string CPFNome 
        {
            get 
            {
                return CPF + " - " + Nome;
            }
        
        }

        //Propriedade que retorne a idade calculada com base na DtNascimento
        public int Idade
        {
            get
            {
                //para descobrir a idade
                //realizamos a conta
                //data atual - data nascimento

                //Iremos usar o Now para recperar a
                //data atual do computador
                
                //--return DateTime.Now.Year - DtNascimento.Year;
                
                //Iremos calcular até com base no dia
                //para maior preciso

                DateTime dataAtual = DateTime.Now;
                int idade = dataAtual.Year - DtNascimento.Year;

                //Olhar com base na data 
                //Se mes maior que o mês de Nascimento
                //mantemos a idade
                //se menor remove 1 da idade 
                //se igual validamos o dia 
                //se dia menor remove 1 da idade
                //se igual ou superior mantemos a idade                

                if (dataAtual.Month < DtNascimento.Month ||
                    (dataAtual.Month == DtNascimento.Month && dataAtual.Day < DtNascimento.Day))
                {
                    idade--;
                }


                return idade;
                    
            }
        }
    }
}
