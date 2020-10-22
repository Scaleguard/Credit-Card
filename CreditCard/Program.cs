using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your ID code:");
            string UserID = Console.ReadLine();

            if (Validate(UserID))
            {
                GetAge(UserID);
                HelloUser(UserID);


            }
            else
            {
                Console.WriteLine("Please enter a vaild ID code!");
            }
            Console.WriteLine("Please enter your Credit Card Number!");
            string CreditCardN = Console.ReadLine();

            if (CreditCard(CreditCardN))
            {
                ValidateCard(CreditCardN);
                
            }else 
            {
                Console.WriteLine("Please enter a valid Credit Card Number");
            }
            Console.WriteLine("Please enter your CVV");
            string CVV = Console.ReadLine();

            if (CVVN(CVV))
            {
                Console.WriteLine("Your card has been accepted");
            }else
            {
                Console.WriteLine("Your card has been declined");
            }
        }

        public static bool Validate(string idcode)
        {
            if (idcode.Length == 11)
            {
                try
                {
                    long.Parse(idcode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong Format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            if (firstNum == 1 || firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Hello, Sir!");
            }
            else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }

        public static int GetYear(string idCode)
        {
            string yearFromCode = idCode.Substring(1, 2);
            string year;

            if (int.Parse(idCode[0].ToString()) > 4)
            {
                year = "20" + yearFromCode;
            }
            else
            {
                year = "19" + yearFromCode;
            }
            int yearParsed = Int32.Parse(year);

            return yearParsed;
        }

        public static void GetAge(string idCode)
        {
            int yearOfBirth = GetYear(idCode);

            DateTime now = DateTime.Now;
            int yearNow = Int32.Parse(now.Year.ToString());
            int age = yearNow - yearOfBirth;
            
            int firstNum = Int32.Parse(idCode[0].ToString());

            if (age < 18)
            {
                Console.WriteLine("You are not authorized to use a credit card yet.");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"");
            }

            
        }

        public static bool CreditCard(string Numbers)
        {
            if(Numbers.Length == 16)
            {     
                try
                {
                    long.Parse(Numbers);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong Format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static long ValidateCard(string Numbers)
        {
            int NumbersFromCode = Int32.Parse(Numbers.Substring(1, 2));


            if (NumbersFromCode >= 51 && NumbersFromCode <= 55)
            {
                Console.WriteLine("You have a valid Credit Card!");
            }
            else
            {
                Console.WriteLine("You do not have a valid Credit Card!");
            }
            long NumberINF = long.Parse(Numbers);

            return NumberINF;
        }

        public static bool CVVN(string CVV)
        {
            if (CVV.Length == 3)
            {
                try
                {
                    long.Parse(CVV);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong Format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
