using System.Text;

namespace Diary
{
    public class FileRead
    {
        public FileRead()
        {
            string directoryPath = "C:\\Users\\Kim Changhyun\\OneDrive - gwnu.ac.kr\\바탕 화면\\Project\\diary\\daydiary";
            // Directorypath 경로에 있는 파일들 가져오기
            string[] files = Directory.GetFiles(directoryPath);
            StringBuilder sb = new();
            foreach (string file in files)
            {
                //가져온 파일은 경로도 같이 적혀있어 가독성 떨어지므로 파일이름만 저장
                sb.Append(Path.GetFileName(file) + "\n");
            }
            Console.WriteLine(sb);

            Console.WriteLine("어떤 파일을 읽어들일까요? (.txt제외 입력)");
            // filename search method + .txt

            string? txtFile = FileExistsSearch(directoryPath) + ".txt";
            string tmp = File.ReadAllText(directoryPath + "\\" +  txtFile);
            // !@# 특수문자 기준으로 토큰화
            string[] page = tmp.Split("!@#");
            new Control(page);
        }

        public string FileExistsSearch(string path)
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
