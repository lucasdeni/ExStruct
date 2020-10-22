using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExStruct
{
    struct Produto //Utilizando Struct ao invés de classe
    {
        //Declaração de variavéis privadas
        private string _nome;
        private double _preço;
        private int _quantidade;

        //Construtor personalizado
        public Produto(string nome, double preço, int quantidade)
        {
            _nome = nome;
            _preço = preço;
            _quantidade = quantidade;
        }

        // Utiização de properties
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preço
        {
            get
            {
                return _preço;
            }
        }
        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }
        public double ValorTotalEmEstoque() //Vai definir o valor total do estoque
        {
            return _preço * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) //Vai adicionar produtos no estoque
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) //Vai remover produtos do estoque
        {
            _quantidade -= quantidade;
        }
        //Declaração da String
        public override string ToString()
        {
            return _nome + ", R$ " + _preço.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
