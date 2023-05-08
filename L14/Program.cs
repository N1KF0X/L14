using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace L14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();

            Regex regIPv4 = new Regex("((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)");
            Regex regIPv6 = new Regex(
                "^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$|" +
                "^([0-9a-fA-F]{1,4}:){1,7}:$|" +
                "^([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}$|" +
                "^([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}$|" +
                "^([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}$|" +
                "^([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}$|" +
                "^([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}$|" +
                "^[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})$|" +
                "^(:(((:([0-9a-fA-F]){1,4}){1,7})|:))$");           

            Match matchesIpv6 = regIPv6.Match(ip);
            Match matchesIpv4 = regIPv4.Match(ip);

            if (matchesIpv4.Success)
            {
                Console.WriteLine($"IP: {matchesIpv4.Value}\nВерсия: 4");
            }
            else if (matchesIpv6.Success)
            {
                Console.WriteLine($"IP: {matchesIpv6.Value}\nВерсия: 6");
            }
            else
            {
                Console.WriteLine("IP: Не найдено\nВерсия: -");
            }
        }
    }
}
