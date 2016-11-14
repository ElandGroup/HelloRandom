using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloRandom.Service
{
    public class RandomService
    {
        public static string GenerateOutTradeNo2()
        {
            var ran = new Random();
            return string.Format("16{0}{1}{2}", ran.Next(100000, 999999), DateTime.Now.ToString("yyyyMMddHHmmssfff"), ran.Next(100, 999));
        }

        public string GenerateOutTradeNo()
        {
            var ran = new Random();
            return string.Format("16{0}{1}{2}", ran.Next(100000, 999999), DateTime.Now.ToString("yyyyMMddHHmmssfff"), ran.Next(100, 999));
        }

    }
}
