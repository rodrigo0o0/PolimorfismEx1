using System.Globalization;

namespace PolimorfismEx1.Entities
{
    internal class Employee
    {
        public string Name { get; protected set; }
        public int Hours { get; protected set; }
        public double valuePerHour { get; protected set; }

        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * valuePerHour;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
