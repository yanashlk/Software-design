using MYClassLibrary5;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створюємо текстовий документ
        TextDocument document = new TextDocument("Початковий вміст");
        // Створюємо редактор та передаємо йому документ
        TextEditor editor = new TextEditor(document);

        bool exit = false;
        Console.WriteLine("Ласкаво просимо до Текстового Редактора!");
        while (!exit)
        {
            // Виводимо поточний стан документа та опції користувачу
            Console.WriteLine("Поточний вміст: " + document.Content);
            Console.WriteLine("Опції:");
            Console.WriteLine("1. Редагувати документ");
            Console.WriteLine("2. Зберегти стан документу");
            Console.WriteLine("3. Відновити стан документу");
            Console.WriteLine("4. Вийти");

            Console.Write("Введіть опцію: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Введіть новий вміст: ");
                    string newContent = Console.ReadLine();
                    document.Content = newContent;
                    Console.WriteLine("Вміст документу оновлено!");
                    break;
                case "2":
                    Memento savedState = editor.Save();
                    Console.WriteLine("Стан документу збережено!");
                    break;
                case "3":
                    if (editor.CanRestore())
                    {
                        editor.Restore();
                        Console.WriteLine("Стан документу відновлено!");
                    }
                    else
                    {
                        Console.WriteLine("Немає збереженого стану.");
                    }
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Невірна опція!");
                    break;
            }

            // Додаємо пустий рядок для розділення між операціями
            Console.WriteLine();
        }

    }
}