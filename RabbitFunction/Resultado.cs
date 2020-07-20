using Microsoft.Azure.WebJobs.Extensions.Timers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumerosPrimosFunction
{
    public class Resultado
    {
        public TimeSpan tiempoTotal{ get; set; }
        public Int64 ultimoPrimo { get; set; }

    }
}
