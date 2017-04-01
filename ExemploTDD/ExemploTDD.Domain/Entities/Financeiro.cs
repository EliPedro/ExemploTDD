using ExemploTDD.Domain.Interfaces;

namespace ExemploTDD.Domain.Entities
{
    public class Financeiro : IFinanceiro
    {
        public decimal ValorImposto(decimal valor, string estado)
        {
            decimal porcentagemImposto;

            if(estado == "SP")
            {
                porcentagemImposto = 10;
            }else
            {
                porcentagemImposto = 20;
            }

            var descontoImposto = valor * (porcentagemImposto / 100);

            return descontoImposto;    
        }
    }
}
