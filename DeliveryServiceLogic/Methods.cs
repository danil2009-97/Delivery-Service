using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Methods
    {
        public static Methods methods = new Methods();

        public bool IsNumber(string txt, int len)
        {
            int n;
            if (int.TryParse(txt, out n) && n.ToString().Count() == len)
                return true;
            else
                return false;
        }
        
        public static Random random = new Random((int)DateTime.Now.Ticks);

        public string GetString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        
    }            
    
}
