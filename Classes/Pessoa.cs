using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public class Pessoa
    {
        public string ome { get; private set; }
        public string CPF { get; private set; }
        public string Senha { get; private set; }
        public IConta Conta { get; set; }

        public void SetNome(string nome)
        {
            this.ome = nome;
        }
        public void SetCPF(string cpf)
        {
            this.CPF = CPF;
        }
        public void SetSenha(string senha)
        {
            this.Senha = Senha;
        }
    }
}