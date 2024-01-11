using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary
{
    internal class FileRead
    {
        public FileRead()
        {
            String Directorypath = "C:\\Users\\Kim Changhyun\\OneDrive - gwnu.ac.kr\\바탕 화면\\Project\\diary\\daydiary";
            // Directorypath 경로에 있는 파일들 가져오기
            String[] files = Directory.GetFiles(Directorypath);
            StringBuilder sb = new();
            foreach (String file in files)
            {
                //가져온 파일은 경로도 같이 적혀있어 가독성 떨어지므로 파일이름만 저장
                sb.Append(Path.GetFileName(file) + "\n");
            }
            Console.WriteLine(sb);

            Console.WriteLine("어떤 파일을 읽어들일까요? (.txt제외 입력)");
            // filename search method + .txt

            String? txtfile = FileExistsSearch(Directorypath) + ".txt";
            String tmp = File.ReadAllText(Directorypath + "\\" +  txtfile);
            // !@# 특수문자 기준으로 토큰화
            String[] page = tmp.Split("!@#");
            new Control(page);
        }

        internal String FileExistsSearch(String path)
        {
            StringBuilder tmp = new();
            while(true)
            {
                tmp.Append(Console.ReadLine());
                if(File.Exists(path + "\\" + tmp.ToString() + ".txt")) 
                { 
                    return tmp.ToString(); 
                }
                Console.WriteLine("존재하지 않는 파일이름입니다.");
                tmp.Clear();
            }
        }
    }
}
