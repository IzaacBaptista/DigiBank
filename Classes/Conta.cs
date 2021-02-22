using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public abstract class Conta :  Banco , IConta
    {
        public Conta()
        {
            this.NumeroConta = "0001"; //primeira conta criada receberá esse número
            Conta.NumeroDaContaSequencial++; // as próximas contas receberão um acréscimo
        }
        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        public double ConsultaSaldo()
        {
            return this.Saldo;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public bool Saca(double valor)
        {
            if(valor > this.ConsultaSaldo())
                return false;
            
            this.Saldo -= valor;
            return true;
        }
        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }
        public string GetNumeroDaAgencia()
        {
            return this.NumeroAgencia;
        }
        public string GetNumeroDaConta()
        {
            return this.NumeroConta;
        }
    }
}