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
            using (TTransport transport = new TSocket("localhost", 9081))
            using (TProtocol protocol = new TBinaryProtocol(transport))

            using (var protocolHelloService = new TMultiplexedProtocol(protocol, "helloService"))
            using (var clientHello = new HelloService.Client(protocolHelloService))
            using (var protocolSchoolService = new TMultiplexedProtocol(protocol, "schoolService"))
            using (var clientSchool = new SchoolService.Client(protocolSchoolService))
            {
                transport.Open();

                Console.WriteLine(clientHello.HelloString("hello world"));
                Console.WriteLine("===========================");
                //调用服务端的方法
                var result = clientSchool.GetAllBanji();
                Console.WriteLine(result.SchoolName);
                foreach (var item in result.AllBanji)
                {
                    Console.WriteLine("--" + item.BanjiName);
                    foreach (var student in item.AllStudents)
                    {
                        Console.WriteLine("----" + student.StudentName);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
