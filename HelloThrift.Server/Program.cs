using HelloThrift.Interface;
using System;
using Thrift;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;

namespace HelloThrift.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //设置服务端口为8080
                TServerSocket serverTransport = new TServerSocket(9081);

                //设置传输协议工厂
                TBinaryProtocol.Factory factory = new TBinaryProtocol.Factory();

                //关联处理器与服务的实现
                TProcessor helloProcessor = new HelloService.Processor(new MyHelloService());
                TProcessor schoolProcessor = new SchoolService.Processor(new MySchoolService());

                //创建服务端对象               
                var processorMulti = new TMultiplexedProcessor();
                processorMulti.RegisterProcessor("helloService", helloProcessor);
                processorMulti.RegisterProcessor("schoolService", schoolProcessor);
                TServer server = new TThreadPoolServer(processorMulti, serverTransport, new TTransportFactory(), factory);

                Console.WriteLine("服务端正在监听9081端口");

                server.Serve();
            }
            catch (TTransportException ex)//捕获异常信息
            {
                //打印异常信息
                Console.WriteLine(ex.Message);

            }
        }
    }
}
