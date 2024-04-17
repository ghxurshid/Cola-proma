using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_proma
{
    public static class RandomGenerator
    {        
        public static string GenerateRandomString()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 10; // Длина строки

            Random random = new Random();
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length);
                result.Append(characters[index]);
            }

            return result.ToString();
        }
    }
}
