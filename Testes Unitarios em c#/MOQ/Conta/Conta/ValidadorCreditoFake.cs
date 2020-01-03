using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class ValidadorCreditoFake : IValidadorCredito
    {
        public bool ValidarCredito(string cpf, decimal valor)
        {
            //não acesso nenhum seviço externo
            return true;
        }
    }
}
