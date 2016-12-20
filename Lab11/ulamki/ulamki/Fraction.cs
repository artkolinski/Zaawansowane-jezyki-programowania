namespace ulamki
{
    public class Fraction
    {
        int Numerator { get; set; }
        int Denominator { get; set; }
        public Fraction()
        {            
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public static Fraction operator + (Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            if (a.Denominator == b.Denominator)
            {
                result.Numerator = a.Numerator + b.Numerator;
                result.Denominator = a.Denominator;
            }
            else
            {
                result.Denominator = a.Denominator*b.Denominator;
                result.Numerator = ((result.Denominator/a.Denominator)*a.Numerator) + ((result.Denominator/b.Denominator)* b.Numerator);
            }
            return result;
        }

        public static Fraction Add(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            if (a.Denominator == b.Denominator)
            {
                result.Numerator = a.Numerator + b.Numerator;
                result.Denominator = a.Denominator;
            }
            else
            {
                result.Denominator = a.Denominator * b.Denominator;
                result.Numerator = ((result.Denominator / a.Denominator) * a.Numerator) + ((result.Denominator / b.Denominator) * b.Numerator);
            }
            return result;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result.Numerator = a.Numerator * b.Numerator;
            result.Denominator = a.Denominator * b.Denominator;
            return result;
        }

        public static Fraction Multiply(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result.Numerator = a.Numerator*b.Numerator;
            result.Denominator = a.Denominator*b.Denominator;
            return result;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction temp = new Fraction(b.Denominator, b.Numerator);
            return Multiply(a,temp);
        }

        public static Fraction Division(Fraction a, Fraction b)
        {
            Fraction temp = new Fraction(b.Denominator, b.Numerator);
            return Multiply(a, temp);
        }

        public override string ToString()
        {
            return "(" + Numerator + " / " + Denominator + ")";
        }
    }
}
