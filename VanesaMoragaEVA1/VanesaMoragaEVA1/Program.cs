using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace VanesaMoragaEVA1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;
            Buque buque1 = new Buque("aaaaa","a","a",10,1,1000,listaContainers);
            Buque buque2 = new Buque("bbbbb","b","b",20,2,2000,listaContainers);
            Containers containers1 = new Containers("1111","1",10,20,1,buque1);
            Containers containers2 = new Containers("2222", "2", 10, 20, 2, buque1);
            Containers containers3 = new Containers("3333", "3", 20, 40, 3, buque2);
            Containers containers4 = new Containers("4444", "4", 20, 40, 4, buque2);




        }
    }
}