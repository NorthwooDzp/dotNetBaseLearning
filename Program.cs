using System;

namespace project
{
    class Program
    {
        public static void Main()
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
    }
}