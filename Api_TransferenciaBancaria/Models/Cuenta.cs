using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_TransferenciaBancaria.Models
{
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Moneda { get; set; }
        [Required]
        public int Saldo { get; set; }
    }
}
