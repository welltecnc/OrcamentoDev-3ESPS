

using System.Windows.Markup;

namespace OrcamentoDev.Models
{
   class Orcamento
    {
        //campos privados 
        private string _cliente;

        private int _horasEstimadas;

        private decimal _valorHora;


        //propriedades publicas para receber campos privados
        public string Cliente
        {
            get => _cliente;
            set => _cliente = value;
        }  

        public int HorasEstimadas
        {
            get => _horasEstimadas;
            set => _horasEstimadas = value > 0 ? value:0;
        }

        public decimal ValorHora
        {
            get => _valorHora;
            set => _valorHora = value > 0 ? value : 0;
        }

        //Construtor

        public Orcamento(string cliente,int horasEstimadas,decimal valorHora)
        {
            _cliente = cliente;
            _horasEstimadas = horasEstimadas;
            _valorHora = valorHora;
        }

        //Metódo virtual para permitir polimorfismo nas classe filhas
        public virtual  decimal CalcularTotal()
        {
            return _horasEstimadas * _valorHora;
        }
    }
}
