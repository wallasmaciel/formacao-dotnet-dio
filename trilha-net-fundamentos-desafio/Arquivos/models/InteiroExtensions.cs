using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.models
{
    public static class InteiroExtensions
    {
        public static bool ehPar(this int numero) => numero % 2 == 0;
    }
}