using System;
using System.Text;

namespace Task02
{
    class Program
    {
        static string ConvertHex2Bin(string HexNumber)
        {
            int n = HexNumber.Length;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (HexNumber[i]>='0' && HexNumber[i]<='9')
                {
                    res += int.Parse(HexNumber[i].ToString())*(int)Math.Pow(16, n-i-1);
                }
                else if(HexNumber[i]=='A')
                {
                    res += 10 * (int)Math.Pow(16, n - i - 1);
                }
                else if (HexNumber[i] == 'B')
                {
                    res += 11 * (int)Math.Pow(16, n - i - 1);
                }
                else if (HexNumber[i] == 'C')
                {
                    res += 12 * (int)Math.Pow(16, n - i - 1);
                }
                else if (HexNumber[i] == 'D')
                {
                    res += 13 * (int)Math.Pow(16, n - i - 1);
                }
                else if (HexNumber[i] == 'E')
                {
                    res += 14 * (int)Math.Pow(16, n - i - 1);
                }
                else if (HexNumber[i] == 'F')
                {
                    res += 15 * (int)Math.Pow(16, n - i - 1);
                }
            }
            StringBuilder sb = new StringBuilder("", res.ToString().Length);
            while(res>0)
            {
                sb.Insert(0, res % 2);
                res /= 2;
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string HexNumber = Console.ReadLine();
            Console.WriteLine(ConvertHex2Bin(HexNumber));
        }
    }
}
