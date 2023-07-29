namespace project85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karra jadval
            int i = 1;
            while (i <= 10)
            {
                while (11>i)
                {
                    Console.WriteLine($"2x{i}={2*i}     3x{i}={3*i}     4x{i}={4*i}      5x{i}={5*i}" +
                        $"   6x{i}={6*i}    7x{i}={7*i}      8x{i}={8*i}    9x{i}={9*i}");
                    i++;
                }
                
            }
        }
    }
}