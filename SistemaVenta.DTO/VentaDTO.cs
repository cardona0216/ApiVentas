using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{
    public class VentaDTO
    {
        public VentaDTO()
        {
            DetalleVenta = new List<DetalleVentaDTO>(); // Inicializar la colección en el constructor
        }

        public int IdVenta { get; set; }

        public string? NumeroDocumento { get; set; }

        public string? TipoPago { get; set; }

        public string? TotalTexto { get; set; }

        public string? FechaRegistro { get; set; }
        public virtual ICollection<DetalleVentaDTO> DetalleVenta { get; set; }
    }

}
