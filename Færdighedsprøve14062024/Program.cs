using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Færdighedsprøve14062024
{
    internal class Program
    {
        List<Group> Groups = new List<Group>();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 'Gymnastikssalssytemet!'");

            Group group1 = new Group();
            group1.Name = "Team A";
            group1.Age = 7;
            group1.NumberOfParticipants = 5;
            group1.Id = 1;

            group1.PresentGroup();

            Group group2 = new Group();
            group2.Name = "Team B";
            group2.Age = 11;
            group2.NumberOfParticipants = 3;
            group2.Id = 2;

            group2.PresentGroup();


            // vi laver et test her af Create, Read, Update og Delete.
            var service = new BookingManager();

            var booking1 = new Booking { Name = "Team X", Age = 10, NumberOfParticipants = 8, Id = 1 };
            service.AddBooking(booking1);

            var booking2 = new Booking { Name = "Team Y", Age = 13, NumberOfParticipants = 6, Id = 2 };
            service.AddBooking(booking2);

            // Read 

            var booking = service.GetBookings();
            Console.WriteLine("All Bookings:");
            foreach (var booking in bookings)
            {
                Console.WriteLine($"{booking.Name}, {booking.Age}, {booking.NumberOfParticipants}, {booking.Id}");
            }

            // Update

            var UpdatedBooking = new Booking { Name = "Team AKS", Age = 12, };
            bool updateResult = service.UpdateBooking(1, UpdatedBooking);
            Console.WriteLine(updateResult ? "Succesfully updated" : "Update failed");


            // Delete

            bool DeleteResult = service.DeleteBooking(2);
            Console.WriteLine(DeleteResult ? "Succesfully deleted" : "Delete failed");

            var remainingBookings = service.GetBookings();
            Console.WriteLine("Remaining bookings:");
            foreach (var booking in remainingBookings) ;
            {
                Console.WriteLine($"{booking.Name}, {booking.Age}, {booking.NumberOfParticipants}, {booking.Id}");
            }
        

        }
    }
}
