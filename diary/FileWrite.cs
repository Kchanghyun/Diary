using System.Text;

namespace Diary
{
    internal class FileWrite
    {
        public bool IsRunning { get; set; } = true;
        public FileWrite()
        {
            Console.WriteLine("일기장에 추가할 내용을 적어주십시오.");
            string path = $@"C:\Users\Kim Changhyun\OneDrive - gwnu.ac.kr\바탕 화면\Project\diary\daydiary\{Log.today}.txt";
            string text = Log.now + "\n\n" + TextWriter() + "\n";
            //File.WriteAllText(path, text);
            //파일이 존재하지 않으면 생성, 존재하면 이어서 쓰기
            File.AppendAllText(path, text);
            //mode 선택
            return;
        }

        public string TextWriter()
        {
            StringBuilder str = new();
            Console.WriteLine("제목을 입력해주세요");
            str.Append("제목 : " + Console.ReadLine() + "\n\n");
            Console.WriteLine("내용을 입력해주세요");
            str.Append("내용 : ");
            while (IsRunning)
            {
                str.Append(Console.ReadLine() + "\n");
                //특수문자 !@# 입력 시 종료
                if (str.ToString().Contains("!@#")) { IsRunning = false; }
            }
            return str.ToString();
        }
    }
}
