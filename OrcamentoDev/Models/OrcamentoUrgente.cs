

namespace OrcamentoDev.Models
{
    //OrçamentoUrgente herda de Orçamento
  class OrcamentoUrgente : Orcamento
    {
       public  bool Urgente { get; set; }

        //Construtor repassando parametros para a classe (orcamento) via base
       public OrcamentoUrgente(string cliente,int horasEstimadas,decimal valorHora, bool urgente)
            :base(cliente,horasEstimadas,valorHora)
        {
            Urgente = urgente;
        }
        //Polimorfismo: sobreescreve o calculo adicionando a taxa de urgência
        public override decimal CalcularTotal()
        {
            decimal totalBase = base.CalcularTotal();
            return Urgente ? totalBase * 1.20m : totalBase;
        }
    }
}
