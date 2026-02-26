using System;
using static System.Console;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 인사 테스트 ===");
Formal.Message fm = new Formal.Message();
fm.SayHello("홍길동");
fm.SayBye("홍길동");

Console.WriteLine("[비격식체]");
Casual.Message cm = new Casual.Message();
cm.SayHello("철수");
cm.SayBye("철수");


 
namespace Formal
{
    public class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕하십니까!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕히 가십시오!");
        }

    }
}
namespace Casual
{
    public class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, [{name}]!");
        }

        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, [{name}]");
        }
    }
}