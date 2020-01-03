using Conta;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConta.Mock
{

    [TestFixture]
    public class ContaTest
    {
        //o objectivo deste metodo é testar o metodo solicitar emprestimo. Visto que para solicitar o emprestimo é necessario a dependecia Validador (para validar o emprestimo), então criamos um mock do objecto
        [Test]
        public void testSolicitarEmprestimo()
        {
            var conta = new Conta.Conta("001",500);

            //conta.setValidadorCredito(new ValidadorCreditoFake());//nosso objecto falso para a classe a ser usada para validar o credito
            
            var mock = new Mock<IValidadorCredito>(); //criamos um objecto falso da depencia que precisamos para validarOEmprestimo (Mockamos)

           // mock.Setup(x => x.ValidarCredito("001", 100)).Returns(true);//simulamos num caso em que o resultado seja true
            mock.Setup(x => x.ValidarCredito(It.IsAny<string>(), It.IsAny<decimal>())).Returns(true);//simulamos num caso em que o resultado seja true, colocamos qualquer valor do tipo de dados esperado

            conta.setValidadorCredito(mock.Object);//Object é um objecto que se comporta tal como esperado (é o objecto simulado do original e não o mock)
            
            int rsEsperado = 600;

            conta.SolicitarEmprestimo(100);//se o credito for aprovado então o emprestimo será realizado

            Assert.IsTrue(rsEsperado == conta.GetSaldo());
        }
        [Test]
        public void TestValidarEmprestimoSuperior()
        {
            var conta = new Conta.Conta("001", 100);
            var mock = new Mock<IValidadorCredito>();
            conta.setValidadorCredito(mock.Object);
            bool resultado = conta.SolicitarEmprestimo(1200);
            mock.Verify(x=>x.ValidarCredito(It.IsAny<string>(),It.IsAny<decimal>()), Times.Never);//verificar se o metodo será executado. Neste caso não o metodo ValidarCredito não será validado visto que o valor informado(1200) é dez vezes superior ao valor actual da conta do cliente
        }
    }
}
