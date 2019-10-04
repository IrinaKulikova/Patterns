using System;

namespace Builder
{
    public abstract class HourseComponent
    {
        public DateTime DateTimeStart { get; }
               

        public HourseComponent()
        {
            DateTimeStart = DateTime.Now;
        }
    }
}