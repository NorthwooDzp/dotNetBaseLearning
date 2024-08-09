using System;

namespace project
{
    class Program
    {
        public static void Main()
        {
            // DataTypes();
            // MathOperations();
            // ConditionalConstructions();
            // SwitchCaseOperator();
            Loops();
        }

        public static void DataTypes()
        {
            #region WholeNumbers

            int numb = 10;
            Console.WriteLine("Result: " + numb);
            numb = 40;
            Console.WriteLine("New result: " + numb);

            //positive integer |x|
            uint number1 = 10;

            // number from 0 to 255
            byte number2 = 255;

            // 16 bits number
            short number4 = 55;

            // 64 bits number
            long number5 = 68888585;

            #endregion


            #region FloatingNumbers

            float number6 = 55.5554f;

            double number3 = 3.14;

            #endregion


            #region AnotherTypes

            string word = "Hello";
            char sym = 's';

            bool isSuccess = true;

            #endregion


            int user1, user2;
            user1 = Convert.ToInt32(Console.ReadLine());
            user2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User1 res: " + user1 + " <-> User2 res: " + user2);
        }

        public static void MathOperations()
        {
            Console.Write("Enter number: ");
            float userInput = float.Parse(Console.ReadLine());

            float result = userInput + 10f;
            result = userInput - 10f;
            result = userInput * 10f;
            result = userInput / 10f;
            result = userInput % 10f;

            result += 5f;
            result -= 6;
            result++;
            result--;


            Console.WriteLine("Result: " + result);

            Console.WriteLine("Enter radius: ");

            float radius = float.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Round area: " + area);
        }

        public static void ConditionalConstructions()
        {
            Console.WriteLine("Enter number: ");
            short input = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter randomly 0 or 1");
            bool boolInput = Convert.ToBoolean(Console.ReadLine());

            if (input == 12)
                Console.WriteLine("yes, correct");
            else if ((input > 5 && boolInput) || (input < 5 && !boolInput))
                Console.WriteLine("Complex condition run");
            else if (input < 16)
                Console.WriteLine("Close to correct");
            else
                Console.WriteLine("Completely wrong");
        }

        public static void SwitchCaseOperator()
        {
            Console.WriteLine("Enter name:");

            string name = Console.ReadLine();

            switch (name)
            {
                case "test":
                    Console.WriteLine("Name is test");
                    break;
                case "qwerty":
                    Console.WriteLine("Qwerty is set");
                    break;
                default:
                    Console.WriteLine("default handler");
                    break;
            }
        }

        public static void Loops()
        {
            for (byte i = 0; i < 19; i++)
            {
                Console.WriteLine("For iteration # {0}", i + 1);
            }

            byte whileCount = 10;
            byte whileIterator = 0;

            while (whileIterator < whileCount)
            {
                if (whileIterator == 5)
                {
                    whileIterator++;
                    continue;
                }

                ;
                Console.WriteLine("While iteration # {0}", whileIterator + 1);
                whileIterator++;
            }

            byte doCount = 12;
            byte doIterator = 0;

            do
            {
                Console.WriteLine("Do iterator # {0}", doIterator + 1);
                doIterator++;

                if (doIterator >= 8)
                {
                    break;
                }
            } while (doIterator < doCount);
        }
    }
}