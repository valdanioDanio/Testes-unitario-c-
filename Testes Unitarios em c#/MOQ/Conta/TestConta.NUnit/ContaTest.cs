using Conta;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConta.NUnit
{
    [TestFixture]
    public class ContaTest
    {
        Conta.Conta conta;
        [SetUp]//primeiro metodo a ser executado antes de executar cada Teste || OneTimeSetUp: vai ser executado uma unica vez
        public void Setup()
        {
            conta = new Conta.Conta("001", 500);
        }

        [TearDown]// metodo a ser executado no final de cada Teste || OneTearDown: vai ser executado uma unica vez
        public void TearDown()
        {
            // vai ser executado no final de tudo
        }

        [Test]
        [Category("ContasBancaria")]
        [TestCase(100)]
        [TestCase(200)]
        [TestCase(100)]
        public void testSacar(int valor)
        {
            //Conta.Conta conta = new Conta.Conta("001", 500);
            bool resultado = conta.Sacar(valor);
            Assert.IsTrue(resultado);
        }  
        
        [Test]
        [Category("ContasBancaria")]
        [Ignore("Aguardando a validação da regra de negócio.")]
        public void testSacar2()
        {
            //Conta.Conta conta = new Conta.Conta("001", 500);
            bool resultado = conta.Sacar(600);
            Assert.IsTrue(resultado);
        }
        [Test]
        public void testString()
        {
            int a = 20;
            Assert.Positive(a);
        }
        
        [Test]
        [Category("Trabalhando com exepções")]
        public void testException()
        {
            Assert.Ignore("Teste de execpção ignorado com sucesso!...");
            Assert.Throws<ArgumentOutOfRangeException>(delegate { conta.Sacar(2200); });
            //Assert.Catch<ArgumentOutOfRangeException>(delegate { conta.Sacar(2200); });
        }
    }
}
