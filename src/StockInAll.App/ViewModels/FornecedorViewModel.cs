using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockInAll.App.ViewModels
{
    public class FornecedorViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Ramo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Guid UsuarioCriacao { get; set; }
        public Guid UsuarioAlteracao { get; set; }

    }
}
