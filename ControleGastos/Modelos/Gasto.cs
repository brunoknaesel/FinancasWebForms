using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Modelos
{
    class Gasto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCompra { get; set; }
        public bool FoiNecessaria { get; set; }
    }
}
