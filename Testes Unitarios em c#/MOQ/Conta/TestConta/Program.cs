using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            testSacarSaldoSuficiente();
            testSacarSaldoInSuficiente();
        }

        private static void testSacarSaldoSuficiente()
        {
            //Arrange: Preparar o que se quer testar
            Conta conta = new Conta("0001", 500);
            bool rsEsperado = true;

            //Act: Executar o que se quer testar
            bool rsObtido = conta.Sacar(200);

            //Asser: Verificar o resultado do teste
            if (rsEsperado == rsObtido)
            {
                Console.WriteLine("testSacarSaldoSuficiente: Ok");
            }
            else
            {
                Console.WriteLine("testSacarSaldoSuficiente: Falhou");
            }

        }

        private static void testSacarSaldoInSuficiente()
        {
            //Arrange: Preparar o que se quer testar
            Conta conta = new Conta("0001",500);
            bool rsEsperado = false;

            //Act: Executar o que se quer testar
            bool rsObtido = conta.Sacar(550);

            //Asser: Verificar o resultado do teste
            if (rsEsperado == rsObtido)
            {
                Console.WriteLine("testSacarSaldoInSuficiente: Ok");
            }
            else
            {
                Console.WriteLine("testSacarSaldoInSuficiente: Falhou");
            }
            Console.ReadKey();
        }
    }
}
