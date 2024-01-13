namespace Diary
{
    public class DiaryService
    {
        public DiaryService()
        {
            SelectMode();
        }

        // write mode, read mode, exit
        void SelectMode()
        {

            // Console.ReadLine().ToString()을 통해 받은 문자열 앞뒤 공백 및 개행 문자 제거
            while (true)
            {
                Console.WriteLine("모드를 선택해주세요 ( w / r / exit )");
                string? mode = Console.ReadLine();

                switch (mode)
                {
                    //write mode
                    case "w":
                        new FileWrite();
                        break;
                    //read mode
                    case "r":
                        new FileRead();
                        break;
                    case "exit":
                        Console.WriteLine("종료");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
