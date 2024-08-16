using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Duration
{
        public class Duration
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public Duration(int _seconds)
            {
                Hours = _seconds / 3600;
                Minutes = (_seconds % 3600) / 60;
                Seconds = (_seconds % 3600) % 60;
            }
            public Duration(int _hours, int _minutes, int _seconds)
            {
                Hours = _hours;
                Minutes = _minutes;
                Seconds = _seconds;
            }

            public override string ToString()
            {
                return $"hours :{Hours} , minutes :{Minutes} , seconds :{Seconds}";
            }

            public override bool Equals(object? obj)
            {
                Duration duration = obj as Duration;

                return this.Hours == duration.Hours && this.Minutes == duration.Minutes &&
                    this.Seconds == duration.Seconds;
            }

            public static bool operator ==(Duration a, Duration b)
            {
                return a.Hours == b.Hours && a.Minutes == b.Minutes && a.Seconds == b.Seconds;
            }
            public static Duration operator ++(Duration left)
            {
                return new Duration(left.Hours, left.Minutes + 1, left.Seconds);

            }
            public static Duration operator --(Duration left)
            {
                return new Duration(left.Hours, left.Minutes - 1, left.Seconds);
            }
            public static bool operator !=(Duration a, Duration b)
            {
                return !(a.Hours == b.Hours && a.Minutes == b.Minutes && a.Seconds == b.Seconds);
            }

            public static bool operator >(Duration d1, Duration d2)
            {
                return d1.Hours > d2.Hours ||
                       (d1.Hours == d2.Hours && d1.Minutes > d2.Minutes) ||
                       (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds > d2.Seconds);
            }

            public static bool operator <(Duration d1, Duration d2)
            {
                return !(d1 > d2) && !(d1 == d2);
            }

            public static bool operator >=(Duration d1, Duration d2)
            {
                return d1 > d2 || d1 == d2;
            }


            public static bool operator <=(Duration d1, Duration d2)
            {
                return d1 < d2 || d1 == d2;
            }

            public static implicit operator DateTime(Duration duration)
            {
                return DateTime.Now
                    .AddHours(duration.Hours)
                    .AddMinutes(duration.Minutes)
                    .AddSeconds(duration.Seconds);
            }

        }
    }