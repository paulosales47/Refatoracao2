﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao2.Aula01
{
    public class CalculadoraImposto
    {
        public double Calcula(double valor, IImposto imposto)
        {
            return imposto.CalculaImposto(valor);
        }
    }
}
