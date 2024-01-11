using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary
{
    // esc 입력하면 Service 클래스부터 다시 시작하게 만들면 이어질듯??
    // 방향키는 어떻게 하는거지?
    internal class Control
    {
        internal Control() { }
        internal Control(String[] args)
        {
            Console.WriteLine(args[0]);
            ControlPage(args);
        }

        internal void ControlPage(String[] page)
        {
            int currentpage = 0;
            while(true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch(keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (currentpage != page.Length - 2)
                        {
                            Console.Clear();
                            Console.WriteLine(page[++currentpage]);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (currentpage != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(page[--currentpage]);
                        }
                        break;
                    case ConsoleKey.Escape:
                        new Service();
                        break;
                    default:
                        Console.Error.WriteLine("방향키 및 esc만 입력해주세요");
                        break;
                }
            }
        }
    }
}
