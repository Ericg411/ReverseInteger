using System;

namespace ReverseInteger
{
    internal class Program
    {
        //Given a signed 32-bit integer x, return x with its digits reversed.
        //If reversing x causes the value to go outside the signed 32-bit integer range[-2^31, 2^31 - 1], then return 0.

        //Assume the environment does not allow you to store 64-bit integers(signed or unsigned).

        static void Main(string[] args)
        {
            Console.WriteLine($"Expected: 321, Got: {Reverse(123)}");
            Console.WriteLine($"Expected: -321, Got: {Reverse(-123)}");
            Console.WriteLine($"Expected: 21, Got: {Reverse(120)}");
            Console.WriteLine($"Expected: 0, Got: {Reverse(1234567899)}");

        }

        public static int Reverse(int x)
        {

            if ((x < 10 && x > 0) || (x > -10 && x < 0))
            {
                return x;
            }

            int reversedNum = 0;
            if (x > 0)
            {
                while (x > 0)
                {
                    if (x < 10)
                    {
                        var comparison = 0;
                        comparison = reversedNum;
                        reversedNum = reversedNum * 10 + x % 10;
                        var string1 = new string(reversedNum.ToString());
                        var string2 = new string(comparison.ToString());
                        if (comparison == 0)
                        {
                            return reversedNum;
                        }
                        if (string1[0] != string2[0])
                        {
                            return 0;
                        }
                        break;
                    }
                    reversedNum = reversedNum * 10 + x % 10;
                    x /= 10;
                }
            }
            else if (x < 0)
            {
                while (x < 0)
                {

                    if (x > -10 && x < 0)
                    {
                        var comparison = 0;
                        comparison = reversedNum;
                        if (reversedNum == 0)
                        {
                            reversedNum = reversedNum * -10 + x % 10;
                        }
                        else if (reversedNum < 0)
                        {
                            reversedNum = reversedNum * 10 + x % 10;
                        }
                        else if (reversedNum > 0)
                        {
                            reversedNum = reversedNum * -10 + x % 10;
                        }
                        var string1 = new string(reversedNum.ToString());
                        var string2 = new string(comparison.ToString());
                        if (comparison == 0)
                        {
                            return reversedNum;
                        }
                        if (string1[1] != string2[1])
                        {
                            return 0;
                        }
                        break;

                    }
                    if (reversedNum == 0)
                    {
                        reversedNum = reversedNum * -10 + x % 10;
                    }
                    else if (reversedNum < 0)
                    {
                        reversedNum = reversedNum * 10 + x % 10;
                    }
                    else if (reversedNum > 0)
                    {
                        reversedNum = reversedNum * -10 + x % 10;
                    }
                    x /= 10;
                }
            }
            else
            {
                return x;
            }
            return reversedNum;
        }
    }
}
