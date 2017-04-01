using ExemploTDD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFinanceiro
{
    [TestClass]
    public class FinanceiroTest
    {
        [TestMethod]
        public void ValorImpostoTeste()
        {
            var financeiro = new Financeiro();
            var valor = financeiro.ValorImposto(20, "SP");

            Console.WriteLine("Estado: SP");
            Console.WriteLine("Valor da venda : 100,00");
            Console.WriteLine("Valor esperado : 10,00");
            Console.WriteLine("Valor retornado: {0}", valor);
            
            Assert.IsTrue(valor == 10, "O valor deve ser 10 se a venda 100 e o estado é SP");
        }
    }
}
