using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    public interface IReservable
    {
        void Reservar();
        void CancelarReserva();
    }

    public class HabitacionHotel : IReservable
    {
        public int NumeroHabitacion { get; set; }
        public string NombreHuesped { get; set; }

        public HabitacionHotel(int numeroHabitacion, string nombreHuesped)
        {
            NumeroHabitacion = numeroHabitacion;
            NombreHuesped = nombreHuesped;
        }

        public void Reservar()
        {
            Console.WriteLine($"Habitación {NumeroHabitacion} reservada a nombre de {NombreHuesped}. ¡Disfrute su estadía!");
        }

        public void CancelarReserva()
        {
            Console.WriteLine($"Reserva de la habitación {NumeroHabitacion} a nombre de {NombreHuesped} ha sido cancelada.");
        }
    }

    public class SalonEventos : IReservable
    {
        public string NombreSalon { get; set; }
        public string NombreOrganizador { get; set; }

        public SalonEventos(string nombreSalon, string nombreOrganizador)
        {
            NombreSalon = nombreSalon;
            NombreOrganizador = nombreOrganizador;
        }

        public void Reservar()
        {
            Console.WriteLine($"El salón de eventos {NombreSalon} ha sido reservado para {NombreOrganizador}.");
        }

        public void CancelarReserva()
        {
            Console.WriteLine($"La reserva del salón de eventos {NombreSalon} a nombre de {NombreOrganizador} ha sido cancelada.");
        }
    }
}
