class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine($"You have {user.TotalPoints} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(user);
                    break;
                case "2":
                    user.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    user.SaveGoals(saveFilename);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    user.LoadGoals(loadFilename);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    Console.Write("Which goal did you accomplish? Enter the goal name: ");
                    string goalName = Console.ReadLine();
                    user.RecordGoal(goalName);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(User user)
    {
        Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("How many points do you want to have associated with this Goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                user.AddGoal(new SimpleGoal(name, points, description));
                break;
            case "2":
                user.AddGoal(new EternalGoal(name, points, description));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int count = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                user.AddGoal(new ChecklistGoal(name, points, description, count, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
}
