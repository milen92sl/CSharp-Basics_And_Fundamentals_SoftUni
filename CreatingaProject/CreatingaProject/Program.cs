using System;

namespace CreatingaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner(System.in);
            String nameArchitect = scanner.nextLine();
            int numberProjects = Integer.parseInt(scanner.nextLine());
            int time = numberProjects * 3;
            System.out.printf("The architect %s will need %d hours to complete %d project/s.", nameArchitect, time, numberProjects);
        }
    }
}
