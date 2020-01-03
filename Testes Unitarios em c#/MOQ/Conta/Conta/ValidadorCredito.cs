using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class ValidadorCredito : IValidadorCredito
    {
        public bool ValidarCredito(string cpf, decimal valor)
        {
            bool StatusSerasa = VerificaSituacaoSerasa(cpf);
            bool StatusSPC = VerificarSituacaoSPC(cpf);
            return (StatusSerasa && StatusSPC);
        }

        private bool VerificarSituacaoSPC(string cpf)
        {
            return true;
        }

        private bool VerificaSituacaoSerasa(string cpf)
        {
            return true;
        }

    }
}
