using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_TransferenciaBancaria.Models
{
    public class Transaccion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CuentaOrigen { get; set; }
        [Required]
        public string CuentaDestino { get; set; }
        [Required]
        public string EntidadDestino { get; set; }
        public int Monto { get; set; }
    }
}
