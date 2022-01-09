using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_101;

namespace ServerChatApp_101_Raditya_Pratama_Putra
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = null;
            try
            {
                serviceHost = new ServiceHost(typeof(ServiceCallBack));
                serviceHost.Open();

                Console.WriteLine("Server is READY....!");
                Console.ReadLine();

                serviceHost.Close();
            }
            catch (Exception e)
            {
                serviceHost = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
