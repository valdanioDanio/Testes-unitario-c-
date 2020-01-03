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
        private IValidadorCredito validadorCredito;

        public Conta(String cpf,decimal valor)
        {
            this.saldo = valor;
            this.cpf = cpf;
        }

        public void setValidadorCredito(IValidadorCredito validador)
        {
            this.validadorCredito = validador;
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

        public bool SolicitarEmprestimo(decimal valor)
        {
            if (this.saldo*10 <= valor)
            {
                return false;
            }

            bool resultado = validadorCredito.ValidarCredito(cpf, valor);

            if (resultado)
            {
                this.saldo += valor;
            }
            return resultado;
        }
    }
}
