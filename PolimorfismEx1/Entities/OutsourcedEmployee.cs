using System.Globalization;


namespace PolimorfismEx1.Entities
{
    internal sealed class OutsourcedEmployee : Employee
    {
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public double AdditionalCharge { get; set; }

        public sealed override double Payment()
        {
            double payment = base.Payment();
            payment += AdditionalCharge + (AdditionalCharge * 0.1);
            return payment;

        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
