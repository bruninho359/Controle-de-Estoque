using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.br.com.projeto.model
{
    public class Produto
    {
        //Atributos Getters e Setters
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtdestoque { get; set; }
        public string validade { get; set; }
        //public int for_id { get; set; } //se pa nao precisa

    }
}
