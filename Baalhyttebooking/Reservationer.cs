using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    //Opgave 3. Oprettet klassen reservationer med instance field,
    //contructor og tilpassende properties.
    public class Reservationer
    {
        //Instance Field
        private int _id;
        private Dictionary<int, Reservation> reservations;

        //Constructor
        public Reservationer(int id)
        {
            _id = id;
            reservations = new Dictionary<int, Reservation>();
        }

        //Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Dictionary<int, Reservation> Reservations
        {
            get { return reservations; }
        }

        public void RegistrerReservation(Reservation reservation)
        {
            int id = reservations.Count + 1;
            reservations.Add(id, reservation);
        }

        public void PrintReservationer()
    {
        foreach (var reservation in reservations.Values)
        {
            Console.WriteLine(reservation);
        }
    }

        public void FjernReservation(Reservation reservation)
        {
            reservations.Remove(reservation.Id);
        }


    }
}
