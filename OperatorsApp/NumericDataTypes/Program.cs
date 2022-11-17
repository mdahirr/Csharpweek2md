namespace NumericDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matilde = 3; //explicitly typed
            var eoin = 3; //implicitly typed
            var stefano = eoin;

            var name = "Cathy";
            var isClean = true;
            var letter = 'P';
            ulong uLongNum = 52uL;


            var prices = new List<decimal>();

            // Integer literals

            var n1 = -65;
            var n2 = 65;
            var n3 = -100_000;
            var n4 = 100_000;
            var n5 = 4_000_000_000;
            var n6 = -5_000_000_000;
            var n7 = 5_000_000_000uL;

            float sum = 0;
            for (int i = 0; i < 100_000; i++)
            { sum += 2 / 5.0f; }
            Console.WriteLine("2/5 added 100,000 times: " + sum);
            Console.WriteLine("2/5 multiplied by 100,000: " + 2 / 5.0f * 100_000);
        }
    }
}