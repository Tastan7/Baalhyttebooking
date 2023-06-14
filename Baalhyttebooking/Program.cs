using Baalhyttebooking;
namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1");
            Console.WriteLine("Test Boernegruppe klassen");

            Boernegruppe b1 = new Boernegruppe("Gruppe 1", "Ble Patruljen", "Pusling", 8);
            Boernegruppe b2 = new Boernegruppe("Gruppe 2", "Ungerne", "Pilt", 10);
            Boernegruppe b3 = new Boernegruppe("Gruppe 3", "Banditterne", "Væbner", 12);

            Console.WriteLine();
            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Opgave 2");
            Console.WriteLine("Test Reservation klassen");

            Reservation r1 = new Reservation(1, new DateTime(2023, 6, 15).AddHours(12), b1);
            Reservation r2 = new Reservation(2, new DateTime(2023, 6, 22).AddHours(14), b2);
            Reservation r3 = new Reservation(3, new DateTime(2023, 6, 29).AddHours(16), b3);
            
            Console.WriteLine();
            Console.WriteLine(r1);
            Console.WriteLine();
            Console.WriteLine(r2);
            Console.WriteLine();
            Console.WriteLine();
            
            Reservationer reservationer = new Reservationer(1);

            Console.WriteLine("Opgave 6. Implementer CRUD som sagt på ogaveteksten og test det");
            Console.WriteLine();
            // Registrer reservationer
            reservationer.RegistrerReservation(r1);
            reservationer.RegistrerReservation(r2);
            reservationer.RegistrerReservation(r3);
            

            // Print alle reservationer
            Console.WriteLine("Print alle reservationer");
            Console.WriteLine();
            reservationer.PrintReservationer();
            Console.WriteLine();

            // Slet en reservation
            reservationer.FjernReservation(r2);
            Console.WriteLine();

            // Print en opdateret reservation efter sletning.
            Console.WriteLine("Den opdaterede liste efter en reservation bliver slettet");
            Console.WriteLine();
            reservationer.PrintReservationer();
            Console.WriteLine();
        }
    }
}


   