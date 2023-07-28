using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_Serasa
{
    internal class Cliente
    {
        public string nome;
        public int idade;
        public Usuario usuario;

        public Cliente( string nome, int idade, Usuario usuario) 
        { 
            this.nome = nome;
            this.idade = idade;
            this.usuario = usuario; //-> antes da pessoa for criar um cliente, ela ja vai ter um usuário
        }
    }
}
// usuario é para a pessoa logar, já o cliente coloca suas informcações 