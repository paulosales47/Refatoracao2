using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao2.Aula01
{
    public class ICMS : IImposto
    {
        private readonly double ALIQUOTA_IMPOSTO_ICMS = 0.03;

        public double CalculaImposto(double valor)
        {
            return (valor * ALIQUOTA_IMPOSTO_ICMS);
        }
    }
}
