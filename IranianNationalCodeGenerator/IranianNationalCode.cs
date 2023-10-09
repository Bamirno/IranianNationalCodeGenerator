using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianNationalCodeGenerator
{
    public static class IranianNationalCode
    {
        public static string Generate()
        {
            var list = new List<string>();
            double sum = 0;

            Random r = new Random();

            for (int i = 10; i > 1; i--)
            {
                var j = Math.Floor(r.NextDouble() * Math.Floor(10.00));
                list.Add(j.ToString());
                sum += j * i;
            }
            var s = sum % 11;
            if (s < 2)
                list.Add(int.Parse(s.ToString()).ToString());
            else if (s >= 2)
                list.Add((11 - s).ToString());
            return String.Join("", list);
        }

        public static bool Validate(string input)
        {

            if (String.IsNullOrEmpty(input))
                return false;

            if (input.Length != 10)
                return false;

            if (!IsNumeric(input))
                return false;

            var allDigitEqual = new[] { "0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };
            if (allDigitEqual.Contains(input)) return false;

            var chArray = input.ToCharArray();
            var num0 = Convert.ToInt32(chArray[0].ToString()) * 10;
            var num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
            var num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
            var num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
            var num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
            var num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
            var num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
            var num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
            var num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
            var a = Convert.ToInt32(chArray[9].ToString());

            var b = (((((((num0 + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;
            var c = b % 11;

            return (((c < 2) && (a == c)) || ((c >= 2) && ((11 - c) == a)));
        }

        private static bool IsNumeric(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
