using System;
using Inn.Entities.Exceptions;

namespace Inn.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date");
            }else  if (checkIn < DateTime.Now
            || checkOut < DateTime.Now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime In, DateTime Out)
        {
            DateTime now = DateTime.Now;
            if (In < now
            || Out < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            else if (Out <= In)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date");
            }
            CheckIn = In;
            CheckOut = Out;
        }

        public override string ToString()
        {
            return "Reservation: Room " + RoomNumber
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", " + Duration() + " nights.";
        }
    }
}