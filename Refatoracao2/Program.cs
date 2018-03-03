using Refatoracao2.Aula01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao2
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new CalculadoraImposto();
            var imposto = calculadora.Calcula(1000, new ICMS());
        }
    }
}
