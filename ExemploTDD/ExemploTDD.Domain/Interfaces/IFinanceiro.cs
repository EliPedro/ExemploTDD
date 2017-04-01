namespace ExemploTDD.Domain.Interfaces
{
   public interface IFinanceiro
   {
        decimal ValorImposto(decimal valor, string estado);
   }
}
