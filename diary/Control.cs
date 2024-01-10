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
        public Control() { }
        public Control(String[] args)
        {
            // 일단 특수문자 !@# 기준으로 토큰 나누기 성공
            foreach(String arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
