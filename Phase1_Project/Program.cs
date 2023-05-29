using Phase1_Project;

class MainClass
{
    public static void Main()
    {

        String[] options = { "1- Service request", "2- Report request" };
        int option = 0;

    Label2:
        Console.WriteLine("\n- Menu -");
        Menu.PrintMenu(options);
        try
        {
            option = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Please enter an integer value between 1 and " + options.Length);
            goto Label2;
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error happened. Please try again");
        }

        Option op = new();
        switch (option)
        {
            case 1:
                Option.Option1();
                goto Label2;
            case 2:
                Option.Option2();
                goto Label2;
            default:
                //throw new Exception("Number Is Invalid");
                Console.WriteLine("Number Is Invalid!");
                goto Label2;
        }
    }
}