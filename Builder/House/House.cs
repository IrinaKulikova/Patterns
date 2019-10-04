using System.Collections.Generic;

namespace Builder
{
    public class House
    {
        private readonly List<HourseComponent> _parts;

        public House()
        {
            _parts = new List<HourseComponent>();
        }

        public void Add(HourseComponent part)
        {
            _parts.Add(part);
        }
    }
}