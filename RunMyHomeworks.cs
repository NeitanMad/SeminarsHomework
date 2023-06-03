using System.Text;

namespace SeminarsHomework
{
    public class RunMyHomeworks
    {
        public static void Info()
        {
            StringBuilder NameOfTask = new StringBuilder();
            NameOfTask.Append(Homework1.LessonName + "\n" + Homework2.LessonName + "\n" + Homework3.LessonName + "\n"
                + Homework4.LessonName + "\n" + Homework5.LessonName + "\n" + Homework6.LessonName + "\n" + Homework7.LessonName + "\n"
                + Homework8.LessonName + "\n");
            Console.WriteLine("Введите номер домашнего задания что бы откррыть его.");
            Console.WriteLine("Доступные домашние работы: \n" + NameOfTask);
        }

        public static (int left, int top) GetCursorPosition()
        {
            return (Console.CursorLeft, Console.CursorTop);
        }

        public static void EnterComand()
        {
            (int left, int top) = GetCursorPosition();
            StringBuilder Command = new StringBuilder();
            char key;
            Console.Write("№ работы: ");
            do
            {
                key = Console.ReadKey().KeyChar;

                if (key != 8 && key != 13) // не BackSpace && не Enter
                {
                    Command.Append(key);
                }
                (int currentLeft, int currentTop) = GetCursorPosition();

                if (key == (char)8)
                {
                    if (Command.Length > 0)
                    {
                        Command.Remove(Command.Length - 1, 1);
                    }

                    if (currentLeft >= left)
                    {
                        Console.SetCursorPosition(currentLeft, top);
                        Console.Write(" ");
                        Console.SetCursorPosition(currentLeft, top);
                    }
                    else
                    {
                        Console.SetCursorPosition(left, top);
                    }
                }

            } while (key != (char)13);

            // Console.WriteLine(Command);
            ParseCommandString(Command.ToString());

        }

        static void ParseCommandString(string Command)
        {
            string[] commandParams = Command.ToLower().Split(' ');
            if (commandParams.Length > 0)
            {

                switch (commandParams[0])
                {
                    case "1":

                        Homework1.RunHomework();

                        break;

                    case "2":

                        Homework2.RunHomework();

                        break;

                    case "3":

                        Homework3.RunHomework();

                        break;

                    case "4":

                        Homework4.RunHomework();

                        break;

                    case "5":

                        Homework5.RunHomework();

                        break;


                    case "6":

                        Homework6.RunHomework();

                        break;

                    case "7":

                        Homework7.RunHomework();

                        break;

                    case "8":

                        Homework8.RunHomework();

                        break;

                    default:
                        Console.WriteLine("Некоректый ввод.");
                        EnterComand();

                        break;
                }

            }
        }

        public static void Start()
        {
            Info();
            EnterComand();
        }

        static void Main(string[] args)
        {
            Start();
        }
    }
}
