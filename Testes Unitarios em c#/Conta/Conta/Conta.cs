using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class Conta
    {
        private String cpf;
        private decimal saldo;

        public Conta(String cpf,decimal valor)
        {
            this.saldo = valor;
            this.cpf = cpf;
        }
        public decimal GetSaldo()
        {
            return this.saldo;
        }
        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }
        public bool Sacar(decimal valor)
        {
            if (valor > this.saldo)
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }


    }
}
