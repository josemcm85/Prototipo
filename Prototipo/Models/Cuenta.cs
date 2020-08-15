using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototipo.Models
{
    public class Cuenta
    {
        public String idCuenta { get; set; }
        public double fondos { get; set;}
        public double saldoR { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(String id)
        {
            this.idCuenta = id;
        }

        public Cuenta(String id,double fondos,double saldo)
        {
            this.idCuenta = id;
            this.fondos = fondos;
            this.saldoR = saldo;
        }

    }
}
