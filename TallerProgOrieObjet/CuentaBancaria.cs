using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    public class CuentaBancaria
    {
        
        public string Titular { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }

        // Constructor para inicializar la cuenta
        public CuentaBancaria(string titular, string numeroCuenta)
        {
            this.Titular = titular;
            this.NumeroCuenta = numeroCuenta;
            this.Saldo = 0;
        }

        public CuentaBancaria()
        {
        }

        // Método para depositar
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($"Se han depositado ${cantidad}. Saldo actual: ${Saldo}");
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
            }
        }

        // Método para retirar con validación
        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                if (Saldo >= cantidad)
                {
                    Saldo -= cantidad;
                    Console.WriteLine($"Se han retirado ${cantidad}. Saldo actual: ${Saldo}");
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes. El saldo no puede ser menor a cero.");
                }
            }
            else
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
            }
        }

        // Método para mostrar el saldo
        public void MostrarSaldo()
        {
            Console.WriteLine($"El saldo actual de la cuenta de {Titular} es: ${Saldo}");
        }
    }
}
