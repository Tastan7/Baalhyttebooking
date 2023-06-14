using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    //Opgave 2. Oprettet klassen reservation med instance field,
    //contructor og tilpassende properties.
    public class Reservation
    {
        //Instance Field
        private int _id;
        private DateTime _tidspunkt;
        private Boernegruppe _boernegruppe;

        //Constructor
        public Reservation(int id, DateTime tidspunkt, Boernegruppe boernegruppe)
        {
            _id = id;
            _tidspunkt = tidspunkt;
            _boernegruppe = boernegruppe;
        }

        //Properties
        public int Id { get { return _id; } }
        public DateTime Tidspunkt { get { return _tidspunkt; } }
        public Boernegruppe Boernegruppe { get { return _boernegruppe; } }

        //Methods
        public override string ToString()
        {
            return $"Reservations ID: {Id}\nTidspunkt {Tidspunkt}\nGruppens Info {Boernegruppe}";
        }

    }

}
