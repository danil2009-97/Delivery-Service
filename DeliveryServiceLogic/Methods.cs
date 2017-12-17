using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public class Methods
    {
        public static Methods methods = new Methods();

        public void UpdateOPsAndOrders()
        {
            var r = new Random();
            int min = r.Next(40, 80);
            var newOrder = new Order
            {
                OrderedTime = DateTime.Now,
                DeliveredTime = DateTime.Now.Add(new TimeSpan(0, min, 0)),
                OrderedProducts = Factory.Default.GetRepositoryCRUD<OrderedProduct>().Data,
                UserId = Factory.Default.GetRepositoryCRUD<User>().Data.FirstOrDefault(u => u.Id == Factory.Default.LoggedUser.Id).Id
            };
                        
            Factory.Default.GetRepositoryCRUD<Order>().AddItem(newOrder);
            Factory.Default.GetRepositoryCRUD<OrderedProduct>().Data.Clear();
        }



        public bool IsNumber(string txt, int len)
        {
            long n;
            if (long.TryParse(txt, out n) && n.ToString().Count() == len)
                return true;
            else
                return false;
        }

        public string CalculateHash(string password)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(hash);
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
