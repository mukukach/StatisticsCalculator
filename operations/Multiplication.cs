namespace operations
{
    public class Multiplication
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Multiply(double[] arrayA)
        {
            double c = 1;
            foreach (double b in arrayA)
            {
                c = Multiply(c, b);
            }

            return c;
        }

        public static int Multiply(int[] arrayA)
        {
            int c = 1;
            foreach (int b in arrayA)
            {
                c = Multiply(c, b);
            }

            return c;
        }
    }
}