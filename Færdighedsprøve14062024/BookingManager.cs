using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve14062024
{
    internal class BookingManager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfPartcipants { get; set; }
        public int Id { get; set; }

        private List<Booking> Bookings = new List<Booking>();
        private int _nextId = 1;

        // Create en Booking, der skal også implementeres en starttime og tjekkes efter åbne tidspunkter ellers skal den retunere en fejlmelding.
        public void AddBooking(Booking booking)
        {
            booking.Id = ++_nextId;
            Bookings.Add(booking);
        }

        //Read, indhenter alle bookings gennem deres id
        public List<Booking> GetBookings()
        {
            return Bookings;
        }

        public Booking GetBookingById(int id)
        {
            return Bookings.FirstOrDefault(b => b.Id == id);
        }

        //Opdater en booking, opdater navn, alder, deltager antal og id. 

        public bool UpdateBooking(int id, Booking UpdatedBooking)
        {
            var booking = GetBookingById(id);
            if (booking == null) ;
            {
                return false;
            }

            booking.Name = UpdatedBooking.Name;
            booking.Age = UpdatedBooking.Age;
            booking.NumberOfParticipants = UpdatedBooking.NumberOfParticipants;
            booking.Id = UpdatedBooking.Id;

        }

        // Delete en Booking,
        public bool DeleteBooking(int id)
        {
            var booking = GetBookingById(id);
            if (booking == null)
            {
                return false;
            }

            Bookings.Remove(booking);
            return true;
        }
    }
}



