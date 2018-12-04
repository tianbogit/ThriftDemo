using HelloThrift.Interface;
using System;
using Thrift.Protocol;
using Thrift.Transport;

namespace HelloThrift.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //设置服务端端口号和地址
                TTransport transport = new TSocket("localhost", 9081);
                transport.Open();

                //设置传输协议为二进制传输协议
                TProtocol protocol = new TBinaryProtocol(transport);

                //创建客户端对象
                SchoolService.Client client = new SchoolService.Client(protocol);

                //调用服务端的方法
                var result = client.GetAllBanji();
                Console.WriteLine(result.SchoolName);
                foreach (var item in result.AllBanji)
                {
                    Console.WriteLine("--" + item.BanjiName);
                    foreach (var student in item.AllStudents)
                    {
                        Console.WriteLine("----" + student.StudentName);
                    }
                }

                Console.ReadKey();

            }
            catch (TTransportException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
