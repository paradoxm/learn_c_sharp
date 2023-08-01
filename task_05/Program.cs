Console.Write("Введите номер дня недели: ");
string? dayNum = Console.ReadLine();

string dayName = getWeekNameDict(dayNum);

if (dayName != string.Empty)
{
    Console.WriteLine($"{dayNum} день недели называется '{dayName}'");
}
else
{
    Console.WriteLine("Неизвестный день недели");
}


string getWeekNameDict(string? dayNum)
{

    var weekNames = new Dictionary<string, string>()
    {
        ["1"] = "Понедельник",
        ["2"] = "Вторник",
        ["3"] = "Среда",
        ["4"] = "Четверг",
        ["5"] = "Пятница",
        ["6"] = "Суббота",
        ["7"] = "Воскресенье",
    };

    if (!weekNames.ContainsKey(dayNum))
    {
        return "";
    }

    return weekNames[dayNum];
}

string getWeekNameCase(string? dayNum)
{
    switch (dayNum)
    {
        case "1": return "Понедельник";
        case "2": return "Вторник";
        case "3": return "Среда";
        case "4": return "Четверг";
        case "5": return "Пятница";
        case "6": return "Суббота";
        case "7": return "Воскресенье";

        default:
            return "";
    }
}