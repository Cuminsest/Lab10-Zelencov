/*string subject = "Программирование";

foreach (char letter in subject) {
    Console.WriteLine(letter);
}

Console.WriteLine("Общее количество букв: " + subject.Length);

int[] grades = { 4, 5, 3, 5, 4 };

int sum = 0;

foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum += grade;
}

double average = (double)sum / grades.Length;
Console.WriteLine("Сумма оценок: " + sum);
Console.WriteLine("Средний балл: " + average);


string[] students = { "Аня", "Ярослав", "Вика" };

int count = 0;

foreach (string student in students) {
    Console.WriteLine(student);
    count++;
}

Console.WriteLine("Всего учеников: " + count);


int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++) {
    points[i] = points[i] + 5;
}

foreach (int point in points) {
    Console.WriteLine(point);
}


string students = { "Аня", "Борис", "Вика" };
int number = 1;

foreach (string student in students) {
    Console.WriteLine($"{number}. {student}");
    number++;
}


int[] numbers = { 10, 25, 4, 8, 17 };

int sum = 0;

foreach (int number in numbers) {
    Console.WriteLine(number);
    sum += number;
}

Console.WriteLine("Сумма чисел: " + sum);

string word = "программирование";

int vowelCount = 0;
string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

foreach (char c in word) {
    if (vowels.Contains(c)) {
        vowelCount++;
    }
}

Console.WriteLine("Количество гласных букв: " + vowelCount);


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


string word = "программирование";

int consonantCount = 0;
string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

foreach (char c in word) {
    if (char.IsLetter(c) && !vowels.Contains(c)) {
        consonantCount++;
    }
}

Console.WriteLine("Количество согласных букв: " + consonantCount);
*/

int grades = { 3, 5, 4, 5, 2, 5, 4 };

int countFives = 0;

foreach (int grade in grades) {
    if (grade == 5) {
        countFives++;
    }
}

Console.WriteLine("Количество пятёрок: " + countFives);
