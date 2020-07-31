using System;
using Hello;
namespace Driver
{
    public class Hello
    {
        public static void Main(String[] args)
        {
            Greet hello = new Greet();
            hello.sayHello();
        }
    }
}