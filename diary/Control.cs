namespace Diary
{
    // esc 입력하면 Service 클래스부터 다시 시작하게 만들면 이어질듯??
    // 방향키는 어떻게 하는거지?
    public class Control
    {
        public Control(string[] args)
        {
            Console.WriteLine(args[0]);
            ControlPage(args);
        }

        public void ControlPage(string[] page)
        {
            int currentPage = 0;
            while(true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch(keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (currentPage != page.Length - 2)
                        {
                            Console.Clear();
                            Console.WriteLine(page[++currentPage]);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (currentPage != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(page[--currentPage]);
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.Error.WriteLine("방향키 및 esc만 입력해주세요");
                        break;
                }
            }
        }
    }
}
