//Итоговая работа


Console.Clear();
 Console.Write("Текст: ");
string userEnter = Console.ReadLine()!;
string[] subs = userEnter.Split();
Console.WriteLine($"\n в строке слова, у которых меньше 3 символов: ");
for (int i = 0; i < subs.Length; i++)
