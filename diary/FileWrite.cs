using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary
{
    internal class FileWrite
    {
        bool isRunning = false;
        public FileWrite()
        {
            isRunning = true;

            Console.WriteLine("일기장에 추가할 내용을 적어주십시오.");
            String path = $@"C:\Users\Kim Changhyun\OneDrive - gwnu.ac.kr\바탕 화면\Project\diary\daydiary\{Log.today}.txt";
            String text = Log.now + "\n\n" + TextWriter() + "\n";
            //File.WriteAllText(path, text);
            //파일이 존재하지 않으면 생성, 존재하면 이어서 쓰기
            File.AppendAllText(path, text);
            //mode 선택
            new Service();
        }

        internal String TextWriter()
        {
            StringBuilder str = new();
            Console.WriteLine("제목을 입력해주세요");
            str.Append("제목 : " + Console.ReadLine() + "\n\n");
            Console.WriteLine("내용을 입력해주세요");
            str.Append("내용 : ");
            while (isRunning)
            {
                str.Append(Console.ReadLine() + "\n");
                //특수문자 !@# 입력 시 종료
                if(str.ToString().Contains("!@#")) { isRunning = false; }
            }
            return str.ToString();
        }
    }
}
