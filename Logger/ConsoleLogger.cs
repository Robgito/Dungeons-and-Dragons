namespace Dungeons_and_Dragons.Logger
{
    public class ConsoleLogger : Ilogger
    {
        public void PrintMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        public string Readinput()
        {
            return Console.ReadLine();
        }
    }
}