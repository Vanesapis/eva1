using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanesaMoragaEVA1
{
    internal class Buque
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int containersContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        List<Containers> listaContainers;

        public Buque(string codigo, string nombre, string pais, int containersContainers, int cantidadContainersCargados, int gastoTransporte, List<Containers> listaContainers)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.pais = pais;
            this.containersContainers = containersContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.gastoTransporte = gastoTransporte;
            this.listaContainers = listaContainers;
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int CantidadContainers { get; set; }
        public int CantidadContainersCargados { get; set; }
        public int GastoTransporte { get; set; }
        public List<Containers> ListaContainers { get; set; }
    }
}
