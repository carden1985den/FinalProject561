class Program
{
    static void Main()
    {
        //Собираем данные о пользователе
        var userData = SetUserData();

        //Выводим в консоль данные о пользователе
        ShowUserData(userData);
    }

    //Собираем данные о пользователе
    static (string name, string sourname, int age, string[] pet, string[] color) SetUserData()
    {
        (string name, string sourname, int age, string[] pet, string[] color) user = (user.name = "", user.sourname = "", user.age = 0, user.pet = [], user.color = []);
        Console.Write("Введите имя: ");
        user.name = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        user.sourname = Console.ReadLine();

        Console.Write("Введите возраст: ");
        user.age = CheckNumber();

        //Запрос даных о питомце
        Console.Write("Есть ли у вас питомец (да/нет): ");
        string hasPet = Console.ReadLine();

        if (hasPet.ToLower() == "да")
        {
            Console.Write("Укажите количество домашних питомцев: ");
            int petCount = CheckNumber();
            user.pet = SetPetData(petCount);
        }

        //Запрос данных о любимом цвете
        Console.Write("Введите количество любимых цветов: ");
        int сolorCount = CheckNumber();
        user.color = SetFavoriteColor(сolorCount);

        return user;
    }

    static string[] SetPetData(int petCount)
    {
        string[] petName = new string[petCount];
        for (int i = 0; i < petCount; i++)
        {
            Console.Write("Введите имя {0}-го питомца: ", i + 1);
            petName[i] = Console.ReadLine();
        }
        return petName;
    }

    static string[] SetFavoriteColor(int numberFavoriteColors)
    {
        string[] favoriteColor = new string[numberFavoriteColors];

        for (int i = 0; i < numberFavoriteColors; i++)
        {
            Console.Write("Введите {0} любимы цвет: ", i + 1);
            favoriteColor[i] = Console.ReadLine();
        }
        return favoriteColor;
    }

    static int CheckNumber()
    {
        do
        {
            if (int.TryParse(Console.ReadLine(), out int parseNum) && parseNum > 0)
            {
                return parseNum;
            }
            else
            {
                Console.WriteLine("Не корректный ввод числа, повторите попытку..");
            }
        } while (true);
    }

    static void ShowUserData((string name, string sourname, int age, string[] pet, string[] color) user)
    {
        Console.WriteLine("\nПользователь: {0} {1}, возраст: {2}", user.name, user.sourname, user.age);

        Console.WriteLine("\nДомашние ивотные:");
        for (int i = 0; i < user.pet.Length; i++)
        {
            Console.WriteLine("{0} {1}", i + 1, user.pet[i]);
        }

        Console.WriteLine("\nЛюбимые цвета:");
        for (int i = 0; i < user.color.Length; i++)
        {
            Console.WriteLine("{0} {1}", i + 1, user.color[i]);
        }
    }
}
