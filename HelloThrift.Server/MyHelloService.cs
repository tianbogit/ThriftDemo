using HelloThrift.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloThrift.Server
{
    public class MyHelloService : HelloService.Iface
    {
        public bool HelloBoolean(bool para)
        {
            System.Threading.Thread.Sleep(1 * 1000);

            Console.WriteLine("客户端调用了HelloBoolean方法");

            return para;
        }

        public int HelloInt(int para)
        {
            System.Threading.Thread.Sleep(1 * 1000);

            Console.WriteLine("客户端调用了HelloInt方法");

            return para;
        }

        public string HelloNull()
        {
            System.Threading.Thread.Sleep(1 * 1000);

            Console.WriteLine("客户端调用了HelloNull方法");

            return null;
        }

        public string HelloString(string para)
        {
            System.Threading.Thread.Sleep(1 * 1000);

            Console.WriteLine("客户端调用了HelloString方法");

            return para;
        }

        public void HelloVoid()
        {
            System.Threading.Thread.Sleep(1 * 1000);

            Console.WriteLine("客户端调用了HelloVoid方法");

            Console.WriteLine("HelloWorld");
        }
    }
}
