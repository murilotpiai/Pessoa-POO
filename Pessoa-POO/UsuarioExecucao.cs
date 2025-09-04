using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_POO
{
    //Classe para manipular o objeto Usuario
    public class UsuarioExecucao
    {   
        //Criar uma lista para armazenar um
        //conjunto de usuario
        
        //por ser privado, so a classe UsuarioExecucao terá acesso a listaUsuario
        private List<Usuario> listaUsuario = 
            new List<Usuario>();

        //Método para adicionar um usuario a lista

        public void Adicionar(Usuario usuario)
        { 
            listaUsuario.Add(usuario);
        }

        public void Remover(Usuario usuario)
        { 
            listaUsuario.Remove(usuario);
        }

        //Criar método 
        //que retorna todos os itens da lista 
        //com a possibilidade de pesquisa por nome 
        public List<Usuario>Pesquisar(string nome)
        {
            //primeiro precisa criar uma nova lista
            //para retornar os dados pesquisados
            //assim a lista original nunca sera afetada
            List<Usuario>listaPesquisa = 
                new List<Usuario>();

            //Neste caso irei realizar um filtro pelo nome na nossa nova lista
            //a deixando apenas com os registros
            //encontrados, semelhante a um SELECT no banco de dados
            //@ = parametro ou variavel 
            //SELECT * FROM Usuario WHERE nome = @nome

            //Utilizar um recurso chamado de FindAll
            //ou seja encontre todos os dados
            //comativeis
            //Para realizar o filtro iremos realizar um recurso
            //chamado LAMBDA
            //ele serve para forçar o apontamento de memoria 
            listaPesquisa = 
                listaUsuario.FindAll(
                    x=> x.Nome.Contains(nome));

            //Se eu não passar nehnum nome para consulta
            //irá retornar todos os itens da lista
            
            //E por fim retornamos a lista filtrada 
            return listaPesquisa;
        }   

    }
}
