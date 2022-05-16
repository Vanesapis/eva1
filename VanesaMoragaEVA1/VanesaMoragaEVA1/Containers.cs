namespace VanesaMoragaEVA1
{
    internal class Containers
    {
        private string codigo;
        private string marca;
        private int capacidadMaxima;
        private byte tamano;
        private bool esRefrigerado;
        private int pesoActual;
        private Buque buque;

        public Containers(string codigo, string marca, int capacidadMaxima, byte tamano, bool esRefrigerado, int pesoActual, Buque buque)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.capacidadMaxima = capacidadMaxima;
            this.tamano = tamano;
            this.esRefrigerado = esRefrigerado;
            this.pesoActual = pesoActual;
            this.buque = buque;
        }
        public string Codigo { get => codigo; set => value; }
        public string Marca { get => marca; set => value; }
        public int CapacidadMaxima { get => capacidadMaxima; set =>value; }
        public byte Tamano { get => tamano; set => value; }
        public bool EsRefrigerado { get; set; }
        public int PesoActual { get => pesoActual; set => value; }
        public Buque Buque { get => buque; set => value; }
    }
}