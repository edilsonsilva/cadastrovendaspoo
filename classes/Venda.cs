using System;

namespace CadastroVendaPoo.classes{
    public class Venda{
        private string cpf;
        private int id;
        private DateTime datavenda;
        public Venda()
        {
            
        }
        public Venda(string cpf, int id, DateTime datavenda)
        {
            this.cpf = cpf;
            this.id = id;
            this.datavenda = datavenda;
        }

            public int Id { get{return id;} set{id = value;} }
            public string Cpf{get{return cpf;}set{cpf=value;}}
            public DateTime DataVenda{get{return datavenda;}set{datavenda = value;}}
    }
}