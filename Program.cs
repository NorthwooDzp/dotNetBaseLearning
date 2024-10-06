using System;
using System.IO;

namespace ConsoleApp1;

class Program
{
    public static void Main()
    {
        // DataTypes();
        // MathOperations();
        // ConditionalConstructions();
        // SwitchCaseOperator();
        // Loops();
        // Arrays();
        // LoopForEach();
        // FilesAndStrings();
        // HandleException();
        OOP();
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

    public static void Arrays()
    {
        byte[] numbers = new byte[3] { 1, 2, 3 };
        for (byte i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("element: " + numbers[i]);
        }

        short[] nums = new short[10];
        Random random = new Random();

        short sum = 0;
        for (byte i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToInt16(random.Next(-5, 60));
            Console.WriteLine("Nums el: " + nums[i]);
            sum += nums[i];
        }

        Console.WriteLine("Summary: the sum is {0} ", sum);

        char[,] symbols = new char[2, 3]
        {
            { 'a', 'b', 'c' },
            { 'd', 'e', 'f' }
        };
    }

    public static void LoopForEach()
    {
        short[] nums = { 6, 5, 4, 5, 6, 8, 5, 2, 5, 6 };

        foreach (var el in nums)
        {
            Console.WriteLine("Current element is {0}", el);
        }

        short[,] newNums =
        {
            { 6, 5, 8 },
            { 9, 16, 54 }
        };

        foreach (var el in newNums)
        {
            Console.WriteLine($"Current element in newNums is {el}");
        }

        // Collections (Generics)

        List<short> collection = new List<short>();
        collection.Add(54);
        collection.Add(8558);
        collection.Add(5448);
        collection.Sort((s, s1) => s < s1 ? 1 : -1);
        collection.ForEach(el => { Console.WriteLine(el); });
        collection.Sort();
        collection.Reverse();
    }

    public static void FilesAndStrings()
    {
        string word = "Hello";
        string word2 = "Not Hello";
        word += "!!!";
        word2 = string.Concat(word2, "+++");
        Console.WriteLine(word);
        Console.WriteLine(word2);
        Console.WriteLine(string.Compare(word2, word));
        List<string> names = "alex,john,bob".Split(',').ToList();
        names.ForEach(name => { Console.WriteLine(name); });
        string combinedNames = String.Join(" | ", names);
        Console.WriteLine(combinedNames);


        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        using (FileStream someFile = new FileStream("info.txt", FileMode.OpenOrCreate))
        {
            byte[] arr = System.Text.Encoding.Default.GetBytes(text);
            someFile.Write(arr);
        }

        using (FileStream stream = File.OpenRead("info.txt"))
        {
            byte[] arr = new byte[stream.Length];
            stream.Read(arr);
            Console.WriteLine("byte-by-byte structure:");
            foreach (var b in arr)
            {
                Console.Write(b);
            }

            Console.WriteLine("");
            string textFromFile = System.Text.Encoding.Default.GetString(arr);
            Console.WriteLine($"Text from file: {textFromFile}");
        }
    }

    public static void HandleException()
    {
        /*try
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e);
        }*/

        var isRunning = true;
        while (isRunning)
        {
            try
            {
                Console.Write("Enter number: ");
                var num = Convert.ToInt32(Console.ReadLine());
                var result = 100 / num;
                Console.WriteLine($"The result is: {result}");
                isRunning = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number should not be 0");
            }
            finally
            {
                Console.WriteLine("Execution iteration ended");
            }
        }
    }

    public static void OOP()
    {
        Bot ammy = new Bot("AIMEe", 12, new byte[]{50, 0, 24});
        // ammy.LogProps();
        ammy.Weight = 24;
        Console.WriteLine(ammy.Weight);
        Console.WriteLine(ammy.Width);

        Killer assasin = new Killer("Robocop", 64, new byte[] {40,20,16}, 55);
        // assasin.LogProps();
        assasin.Laser();

        Robot[] robots = new Robot[] { ammy, assasin };

        List<Robot> robotsList = new List<Robot>();
        robotsList.Add(ammy);
        robotsList.Add(assasin);
        robotsList.Add(new Killer());

        foreach (var robot in robotsList)
        {
            robot.LogProps();
            
            Console.WriteLine("Is Killer => " + (robot is Killer));
            Console.WriteLine("Is Robot => " + (robot is Robot));
            Console.WriteLine("<--===|***|===-->");
        }
    }
}