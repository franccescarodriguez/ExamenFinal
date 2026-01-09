using System;

namespace ExamenFinal.Models
{
    public class Pago
    {
        public int PagoId { get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
    }
}
