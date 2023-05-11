using System;
namespace Lab_Theatre
{
    public struct Time
    {
        private int hours;
        private int minutes;

        public Time(int hours, int minutes = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public override string ToString()
        {
            return $"{hours}:{minutes:d2}";
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            if (Math.Abs((((lhs.hours * 60) + (lhs.minutes)) - ((rhs.hours * 60) + (rhs.minutes)))) < 15)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            if (lhs == rhs)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

    
}

