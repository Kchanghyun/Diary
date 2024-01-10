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
            try
            {
                isRunning = true;
                Log log = new();
                Console.WriteLine("일기장에 추가할 내용을 적어주십시오.");
                //String path = $@"C:\{new Log().today}.txt";
                String path = $@"C:\Users\Kim Changhyun\OneDrive - gwnu.ac.kr\바탕 화면\Project\diary\daydiary\{log.today}.txt";
                String text = log.now + "\n\n" + TextWriter() + "\n";
                File.WriteAllText(path, text);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
                if(str.ToString().Contains("!@#")) { isRunning = false; }
            }
            return str.ToString();
        }
    }
}
