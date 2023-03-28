class circle
{
    public double pl;

    public double Square()
    {
    }
    public double Perimetr()
    {
    }
}

class triangle
{
    public int a;
    public int b; 
    public int c;

    public double Square()
    {
    }

    public double Perimetr()
    {
    }
}

class square
{
    public int a;

    public double Square()
    {
    }

    public double Perimeter()
    {
    }
}

class TrafficLight
{
    private void ChangeColor(string color)
    {
    }

    public string GetColor()
    {
    }
}


class User
{
    private int age;
    private string login;
    private string email;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }

    public string Login
    {
        get
        {
            return login;
        }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Длина логина должна быть не менее 3 символов");
            }
            else
            {
                login = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (value.Contains('@'))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("Требуется знак @");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Email = Console.ReadLine();
        Console.WriteLine(user.Email);
    }
}