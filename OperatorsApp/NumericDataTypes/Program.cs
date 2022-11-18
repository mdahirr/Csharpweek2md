namespace NumericDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int matilde = 3; //explicitly typed
            //var eoin = 3; //implicitly typed
            //var stefano = eoin;

            //var name = "Cathy";
            //var isClean = true;
            //var letter = 'P';
            //ulong uLongNum = 52uL;


            //var prices = new List<decimal>();

            // Integer literals

            //var n1 = -65;
            //var n2 = 65;
            //var n3 = -100_000;
            //var n4 = 100_000;
            //var n5 = 4_000_000_000;
            //var n6 = -5_000_000_000;
            //var n7 = 5_000_000_000uL;

            //float sum = 0;
            //for (int i = 0; i < 100_000; i++)
            //{ sum += 2 / 5.0f; }
            //Console.WriteLine("2/5 added 100,000 times: " + sum);
            //Console.WriteLine("2/5 multiplied by 100,000: " + 2 / 5.0f * 100_000);

            //var result = 5.50 / 5;
            //double myInt = result;

            //byte num = Byte.MaxValue;
            //Console.WriteLine("Byte max: " + num);
            //num += 1;
            //Console.WriteLine(num);

            //sbyte num2 = SByte.MaxValue;
            //Console.WriteLine("SByte max: " + num2);
            //num += 1;
            //Console.WriteLine(num);

            //int num3 = int.MaxValue;
            //Console.WriteLine("Int max: " + num3);
            //num += 1;
            //Console.WriteLine(num3);

            //double x = 3.14159265359;
            //float y = (float)x;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int numCows = 260;
            //uint countCows = (uint)numCows;
            //byte byteCows = (byte)numCows;

            //int bankBalance = -2;
            //uint posBalance = (uint)bankBalance;

            //Console.WriteLine(Convert.ToString(bankBalance, 2));
            //Console.WriteLine(Convert.ToString(posBalance, 2));
            //Console.WriteLine(Convert.ToString(numCows, 2));
            //Console.WriteLine(Convert.ToString(byteCows, 2));

            //float pi = 3.14f;
            //bool boolPi = (bool)pi;
            //DateTime piDay = (DateTime)pi;


            // convert Class

            //// no conversion
            //var theInt = 5;
            //var anotherInt = Convert.ToInt32(theInt);

            ////safe - widening
            //var myDouble = Convert.ToDouble(theInt);    

            //// unsafe - narrowing with no data loss
            //var myShort = Convert.ToInt16(theInt);
            //double myPi = 3.14;
            //float floatPi = Convert.ToSingle(myPi);

            // unsafe conversions with loss of data
            // int myCows = 260;
            // byte myByteCows = Convert.ToByte(myCows);

            // int myBankBalance = -2;
            // uint myPosBalance = Convert.ToUInt32(myBankBalance);

            // DateTime piDay = Convert.ToDateTime(myPi);

            // int myFive = Convert.ToInt32("five");

            byte num = Byte.MaxValue;
            Console.WriteLine("Byte max: " + num);
            num += 1;
            Console.WriteLine(num);
        }
    }
}