using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenFinal.Models
{
    public class Pago
    {
        public int PagoId { get; set; }
        public required string MetodoPago { get; set; }
        public DateTime FechaPago { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Monto { get; set; }
    }
}
