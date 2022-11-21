class Program
{
    public static PersonList personlist;
    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenu();
    }
    public static void PrintMenu()
    {
        PrintListMenuLogout();
        PresentMenuLogout();
    }
    public static void PrintListMenuLogout()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Login");
        Console.WriteLine("2.Register");
        Console.WriteLine("-------------------------------");

    }
    public static void PresentMenuLogout()
    {
        Console.Write("Please select menu : ");
        int menuLogout = (int.Parse(Console.ReadLine()));
        switch (menuLogout)
        {
            case 1:
                ShowLogin();
                break;
            case 2:
                InputRegisterUser();
                break;
            default:
                break;
        }
        PrintMenu();

    }
    public static void PrintListMenuLogin()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Register Idea Camp 2022");
        Console.WriteLine("2.Logout");
        Console.WriteLine("-------------------------------");
    }
    public static void InputMenuLoginFromKeyboard()
    {
        PresentMenuLogin();
    }
    public static void PresentMenuLogin()
    {
        Console.Write("Please select menu : ");
        int menuLogin = (int.Parse(Console.ReadLine()));
        switch (menuLogin)
        {
            case 1:
                InputRegisterUser();
                break;
            case 2:
                PrintMenu();
                break;
            default:
                break;
        }
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();

    }

    public static void ShowLogin()
    {
        Console.Clear();
        Console.WriteLine("Write < exit > for out");
        string id = InputID();
        PrintMenu();

    }


    public static void InputRegisterUser()
    {
        Console.Clear();
        PrintMenuRegister();
        PresentMenuRegister();

    }
    
    public static void PrintMenuRegister()
    {
        Console.WriteLine("1.User");
        Console.WriteLine("2.Admin");
    }
    public static void PresentMenuRegister()
    {
        Console.Write("Please select group : ");
        int menuregis = (int.Parse(Console.ReadLine()));
        switch(menuregis)
        {
            case 1:
                ShowInputUser();
                break;
            case 2:
                ShowInputAdmin();
                break;
            default:
                break;
        }
    }
    public static void ShowInputUser()
    {
        Console.Clear();
        Console.WriteLine("Register User");
        string ID = InputID();
        if(personlist.findID(ID))
        {
            Console.WriteLine("Input ID Again");
            Console.ReadLine();
            ShowInputUser();
            return;
        }
        string Password = InputPassword();
        string Name = InputName();
        string Surname = InputSurname();
        string Number = InputNumber();

        Admin admin = new Admin(ID,Password,Name,Surname,Number);

        Program.personlist.AddNewPerson(admin);
    }

    public static void ShowInputAdmin()
    {
        Console.Clear();
        Console.WriteLine("Register Admin");
        string ID = InputID();
        if(personlist.findID(ID))
        {
            Console.WriteLine("Input ID Again");
            Console.ReadLine();
            ShowInputAdmin();
            return;
        }
        string Password = InputPassword();
        string Name = InputName();
        string Surname = InputSurname();
        string Number = InputNumber();

        User user = new User(ID,Password,Name,Surname,Number);
        

        Program.personlist.AddNewPerson(user);
    }

    public static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personlist = new PersonList();
    }
    
    public static string InputID()
    {
        Console.Write("ID : ");
        return Console.ReadLine();
    }
    public static string InputPassword()
    {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    public static string InputName()
    {
        Console.Write("Name : ");
        return Console.ReadLine();
    }
    public static string InputSurname()
    {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    public static string InputNumber()
    {
        Console.Write("Number : ");
        return Console.ReadLine();
    }

}