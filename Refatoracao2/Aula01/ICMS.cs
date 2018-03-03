using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao2.Aula01
{
    public class ICMS : IImposto
    {
        public double CalculaImposto(double valor)
        {
            return (valor * 0.03);
        }
    }
}
