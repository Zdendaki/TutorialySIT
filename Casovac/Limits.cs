using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casovac
{
    class Limits
    {
        public List<TimeLimit> TimeLimits = new List<TimeLimit>();

        public Limits()
        {
            TimeLimits.Add(new TimeLimit(new TimeSpan(0, 0, 30), Color.FromArgb(52, 152, 219), "Úvodní část"));
            TimeLimits.Add(new TimeLimit(new TimeSpan(0, 2, 30), Color.FromArgb(26, 188, 156), "Interview"));
            TimeLimits.Add(new TimeLimit(new TimeSpan(0, 4, 0), Color.FromArgb(231, 76, 60), "Samostatný ústní projev"));
            TimeLimits.Add(new TimeLimit(new TimeSpan(0, 5, 0), Color.FromArgb(155, 89, 182), "Ústní projev"));
            TimeLimits.Add(new TimeLimit(new TimeSpan(0, 3, 0), Color.FromArgb(52, 73, 94), "Interakce"));
        }

        public TimeLimit GetCurrentPart(TimeSpan time)
        {
            foreach (TimeLimit l in TimeLimits)
            {
                if (l.Time >= time)
                    return l;
                else
                    time -= l.Time;
            }

            return null;
        }

        public TimeSpan TimeToPartEnd(TimeSpan time)
        {
            foreach (TimeLimit l in TimeLimits)
            {
                if (l.Time >= time)
                    return time - l.Time;
                else
                    time -= l.Time;
            }

            return new TimeSpan(0, 0, 0);
        }
    }

    class TimeLimit
    {
        public TimeSpan Time { get; set; }

        public Color Color { get; set; }

        public string Name { get; set; }

        public TimeLimit(TimeSpan time, Color color, string name)
        {
            Time = time;
            Color = color;
            Name = name;
        }
    }
}
