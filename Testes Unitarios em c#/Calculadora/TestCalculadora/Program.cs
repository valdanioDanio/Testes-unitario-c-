using System;

namespace TestCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            testSomar();
            testeSomarNumerosNegativos();
        }

        private static void testeSomarNumerosNegativos()
        {
            float resultadoEsperado = -100;
            var calculadora = new Calculadora.Calculadora();
            float resultado = calculadora.somar(-20, -80);
            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("testeSomarNumerosNegativos: Ok");
            }
            else
            {
                Console.WriteLine("testeSomarNumerosNegativos: Falhou");
            }
            Console.ReadKey();
        }

        public static void testSomar()
        {
            float resultadoEsperado = 300;
            var calculadora = new Calculadora.Calculadora();
            float resultado = calculadora.somar(200, 100);
            if(resultado == resultadoEsperado)
            {
                Console.WriteLine("TestSomar: Ok");
            }
            else
            {
                Console.WriteLine("TestSomar: Falhou");
            }
        }

    }
}
