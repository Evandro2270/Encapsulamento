using System.Globalization;

namespace VendasPodutos
{
    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        private string _nome;
        private double _preco;
        private int _quantidade;
        public string Nome
        {
            get { return _nome; } // Properties
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }
        public double Quantidade
        {
            get { return _preco; }
        }

        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        /*public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }
     
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
         */
        public double ValorTotalemEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CI)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalemEstoque().ToString("F2", CI);

        }

    }
}
