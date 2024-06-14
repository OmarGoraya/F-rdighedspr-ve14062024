using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve14062024
{
    internal class Booking
    {
        public DateTime Date { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int HallId { get; set; }
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public Booking(DateTime date, DateTime start, DateTime end, int hallId, int id, DayOfWeek dayOfWeek)
        {
            Date = date;
            Start = start;
            End = end;
            HallId = hallId;
            Id = id;
            DayOfWeek = dayOfWeek;

        }

        public Booking() 
        { 
        
        }    

        public void PresentBooking(Booking booking)
        {
            Console.WriteLine($"Date; {}, Start {}, End {}, Hall Id {}, Day of the week {}");
        }
    }
}}