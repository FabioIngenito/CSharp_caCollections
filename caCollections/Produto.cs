namespace caCollections
{
    internal class Produto : IComparable<Produto>
    {
        private string nome;
        private decimal valor;

        public Produto(string _nome, decimal _valor)
        {
            nome = _nome;
            valor = _valor;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public decimal Valor
        {
            get => valor;
            set => valor = value;
        }

        public int CompareTo(Produto? outro)
        {
            if (outro == null) return -1;

            return this.valor.CompareTo(outro.valor);
        }

        /// <summary>
        /// Fazendo o Override (objeto.nomeDaClasse)
        /// </summary>
        /// <returns>Retorna Texto Personalizado</returns>
        public override string ToString()
        {
            return $"Produto: {nome} / Valor: R${valor}";
        }

        /// <summary>
        /// Alterando os métodos Equals() e GetHashCode() para levar 
        /// em consideração os títulos em maiúsculo com ToUpper(), nós 
        /// podemos garantir que as diferenças entre maiúsculas e minúsculas 
        /// vão ser ignoradas na hora de comparar as aulas e assim evitaremos 
        /// a duplicidade no HashSet!
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Produto outra) return false;

            return nome.ToUpper().Equals(outra.nome.ToUpper());
        }

        public override int GetHashCode()
        {
            return nome.GetHashCode();
        }
    }
}
