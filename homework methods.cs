namespace metodsCsarph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4;
            double b = 5;
            double are = FindRectangle(4, 5);
            Console.Writeline(are);

            {
                static double FindRectangle(double a, double b)
                {
                    return a * b;
                }
            }




        }
    }