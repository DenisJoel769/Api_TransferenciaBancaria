using Api_TransferenciaBancaria.Data;
using Api_TransferenciaBancaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_TransferenciaBancaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Transferencia : ControllerBase
    {

        private readonly AplicationDbContext _context;
        public Transferencia(AplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost()]
        [Route("Cuenta")]
        public async Task<IActionResult> Post([FromBody] Cuenta cuenta) 
        {
            try 
            {
                _context.Cuenta.Add(cuenta);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Los datos fueron agregado a la cuenta.." });
            }
            catch(Exception error) 
            {
                return BadRequest(error.Message);
            }           
        }

        [HttpGet]
        [Route("Cuenta")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listCuentas = await _context.Cuenta.ToListAsync();
                return Ok(listCuentas);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


        [HttpPost()]
        public async Task<IActionResult> Post( [FromBody] Transaccion Datos)
        {
            try
            {

                var cuentas =   from  c in _context.Cuenta  select c ;

                if (_context.Cuenta.Find(1).Saldo > Datos.Monto)
                {
                    var montoActual = _context.Cuenta.Find(1).Saldo - Datos.Monto;

                    _context.Transaccions.Add(Datos);
                    await _context.SaveChangesAsync();

                    return Ok(new { message = "La transaccion fue realizada con exito!!. Tu saldo actual es: " + montoActual });
                    
                }
                else 
                {
                    return Ok(new { message = "Saldo insuficiente" });
                }                                 
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
