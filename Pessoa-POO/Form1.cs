using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pessoa_POO
{
    public partial class Form1 : Form
    {   
        //Criar a instancia de acessoa
        //a classe de UsuarioExecucao
        UsuarioExecucao usuarioExecucao = 
            new UsuarioExecucao();
        public Form1()
        {
            InitializeComponent();
        }

        //Método para atualizar a List Box
        //com os dados cadastrados 

        void AtualizarListBox()
        {   
            //limpar a fonte de dados do List Box
            lstUsuario.DataSource = null;

            //Chamar o método pesquisar da classe
            //para retornar uma lista de usuarios
            //passando o parametro vazio
            //para retornar todos os usuarios

            //Por hora não vamos implementar a pesquisa
            //somente exibir todos
            lstUsuario.DataSource = 
                usuarioExecucao.Pesquisar("");

            //Definir qual campo de Usuario será
            //exibido na List Box
            lstUsuario.DisplayMember = "NomeEmail";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Pulamos a parte de validação
            //pois nao é o objetivo no momento
            //o Foco é a manipulação do objetivo e da lista

            //Criar uma instancia para usuario
            Usuario usuario = new Usuario();

            //Atribuir as informações ao objeto
            usuario.CPF = txtCPF.Text;
            usuario.Nome = txtNome.Text;
            usuario.DtNascimento = dtpDtNascimento.Value;
            usuario.Email = txtEmail.Text;  
            usuario.Senha = txtSenha.Text;  

            //Agora podemos adicionar o nosso objeto
            //a lista de objetos usando o método adicionar
            //da classe de execução
            usuarioExecucao.Adicionar(usuario);

            //Precisamos atualizar a list box
            AtualizarListBox();

            //limpar os campos

            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDtNascimento.Value = DateTime.Now;
        }

        //Método para extrair o usuario
        //selecionado na list box 
        Usuario ExtrairUsuario()
        {
            //Recuperar o registro selecionado 
            //e transformar no objeto Usuario
            //usado o as para converter p item em objeto
            return lstUsuario.SelectedItem as Usuario;
        }

        private void lstUsuario_DoubleClick(object sender, EventArgs e)
        {
            //Exibir os dados do objeto selecionado
            Usuario usuarioSelecionado = new Usuario();
            usuarioSelecionado = ExtrairUsuario();

            //Exibir os dados em tela 
            txtVisuCPF.Text = usuarioSelecionado.CPF;
            txtVisuNome.Text = usuarioSelecionado.Nome;
            txtVisuEmail.Text = usuarioSelecionado.Email;
            txtVisuSenha.Text = usuarioSelecionado.Senha;
            txtVisuDtNascimento.Text = usuarioSelecionado.DtNascimento.ToShortDateString();
            txtVisuIdade.Text = usuarioSelecionado.Idade.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //chamar o método remover da classe de execução 

            usuarioExecucao.Remover(ExtrairUsuario());
            AtualizarListBox();
        }
    }
}
