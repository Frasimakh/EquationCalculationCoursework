using System;

namespace EquationСalculationCoursework
{
    public class Base
    {
        virtual public double f(double x)
        {return x;}

        virtual public double fs(double x)
        {
            return x;
        }
        virtual public double fss(double x)
        {
            return x;
        }
    }
    public class Derivative2:Base
    {
        public override double f(double x)
        {
            return Data.A * x * x + Data.B * x + Data.C;
        }

        public override double fs(double x)
        {
            return 2 * Data.A * x + Data.B;
        }
        public override double fss(double x)
        {
            return 2 * Data.A;
        }
    }
    public class Derivative3 : Base
    {
        public override double f(double x)
        {
            return Data.A * x * x * x + Data.B * x * x + Data.C * x + Data.D;
        }

        public override double fs(double x)
        {
            return 3 * Data.A * x * x + 2 * Data.B * x + Data.C;
        }
        public override double fss(double x)
        {
            return 6 * Data.A * x + 2 * Data.B;
        }
    }

    public class Derivative4 : Base
    {
        public override double f(double x)
        {
            return Data.A * x * x * x * x + Data.B * x * x * x + Data.C * x * x + Data.D * x + Data.E;
        }

        public override double fs(double x)
        {
            return 4 * Data.A * x * x * x + 3 * Data.B * x * x + 2 * Data.C * x + Data.D;
        }
        public override double fss(double x)
        {
            return 12 * Data.A * x * x + 6 * Data.B * x + 2 * Data.C;
        }
    }
}
