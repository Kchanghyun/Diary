using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary
{
    internal class Service
    {
        public Service()
        {
            mode();
        }

        void mode()
        {
            Console.WriteLine("모드를 선택해주세요 ( w / r / exit )");
            String? mode = Console.ReadLine();
            Console.WriteLine("Switch start");

            // Console.ReadLine().ToString()을 통해 받은 문자열 앞뒤 공백 및 개행 문자 제거
            switch (mode)
            {
                case "w":
                    Console.WriteLine("w choice");
                    new FileWrite();
                    break;
                case "r":
                    Console.WriteLine("R choice");
                    new FileRead();
                    break;
                case "exit":
                    Console.WriteLine("종료");
                    break;
                default: 
                    Console.WriteLine("Invalid choice"); 
                    break;
            }
        }
    }
}
