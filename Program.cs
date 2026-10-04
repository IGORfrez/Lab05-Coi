// int dayNumber = 6;
// switch (dayNumber)
// {
//     case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }

// int score = 78;
// switch (score)
// {
//     case >= 0 and <= 39:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and <= 59:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and <= 79:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

int temperature = 22;
string category = temperature switch
{
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко"
};
Console.WriteLine(category);

// string role = "teacher";
// string result = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     _ => "Ограниченный доступ"
// };
// Console.WriteLine(result);

// int age = 17;
// bool hasTicket = true;
// switch (age)
// {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2;
// switch (level)
// {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }

// int month = 12;
// string season = month switch
// {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };
// Console.WriteLine(season);

// int age = 25;
// string ageGroup = age switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребёнок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     >= 65 => "Пенсионер"
// };
// Console.WriteLine(ageGroup);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// string role = "teacher";
// bool isAccountConfirmed = false; // статус подтверждения аккаунта

// switch (role)
// {
//     case "admin":
//         Console.WriteLine("Полный доступ");
//         break;
//     case "teacher" when isAccountConfirmed:
//         Console.WriteLine("Доступ преподавателя");
//         break;
//     case "teacher":
//         Console.WriteLine("Требуется подтверждение");
//         break;
//     case "user":
//         Console.WriteLine("Ограниченный доступ");
//         break;
//     default:
//         Console.WriteLine("Доступ запрещён");
//         break;
// }

// Console.Write("Введите количество очков: ");
// int points = int.Parse(Console.ReadLine()); // можно менять для тестирования

// string playerLevel = points switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 999 => "Новичок",
//     >= 1000 and <= 4999 => "Опытный",
//     >= 5000 and <= 9999 => "Продвинутый",
//     >= 10000 => "Мастер"
// };

// Console.WriteLine($"Очки: {points} → Уровень: {playerLevel}");