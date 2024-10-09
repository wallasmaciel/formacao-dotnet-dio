using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Arquivos.models
{
    public class Venda
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }
        [JsonProperty(nameof(Produto))]
        public string Produto { get; set; }
        [JsonProperty(nameof(Preco))]
        public decimal Preco { get; set; }
        [JsonProperty(nameof(DataVenda))]
        public DateTime DataVenda { get; set; }

        public Venda(int Id, string Produto, decimal Preco, DateTime DataVenda) {
            this.Id = Id;
            this.Produto = Produto;
            this.Preco = Preco;
            this.DataVenda = DataVenda;
        }
    }
}