using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    //Opgave 1. Oprettet klassen Boernegruppe med instance field,
    //contructor og tilpassende properties.
    public class Boernegruppe
    {
        //Instance Field
        private string _id;
        private string _navn;
        private string _aldersgruppe;
        private int _antalDeltagere;

        //Constructor
        public Boernegruppe(string id, string navn, string aldersgruppe, int antalDeltagere)
        
        {
            _id = id;
            _navn = navn;
            _aldersgruppe = aldersgruppe;
            _antalDeltagere = antalDeltagere;


        }
            
        //Properties
        public string Id { get { return _id; } }
        public string Navn { get { return _navn; } }
        public string Aldersgruppe { get {  return _aldersgruppe; } }
        public int AntalDeltagere { get {  return _antalDeltagere; } }


        //Methods
        public override string ToString()
        {
            return $"ID: {Id}\nNavn: {Navn}\nAldersgruppe: {Aldersgruppe}\nAntal Deltagere: {AntalDeltagere}";
        }


    }   
}
