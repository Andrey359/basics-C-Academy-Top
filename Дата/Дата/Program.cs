public class MainClass
{
     static string checkYear(int year)
        {
            if (year % 400 == 0)
            {
                return "високосный год";
            }

            else if (year % 100 == 0)
            {
                return "не високосный год";
            }

            else if (year % 4 == 0)
            {
                return "високосный год";
            }

            else
            {
                return "не високосный год";
            }
        }
        static string checkMonth(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "зима";
                case 3:
                case 4:
                case 5:
                    return "весна";
                case 6:
                case 7:
                case 8:
                    return "лето";
                case 9:
                case 10:
                case 11:
                    return "осень";
            }
            return "Ошибка, нет такого месяца";
        }
    public static void Main()
    {
        string dateText;
        int year, month, day;

        dateText = Console.ReadLine();
        string[] date = dateText.Split(".");

        year = int.Parse(date[0]);
        month = int.Parse(date[1]);
        day = int.Parse(date[2]);

        Console.WriteLine(checkMonth(month) + ", " + checkYear(year));

    }
}