using ClassLibraryATM;
using System;
using System.Text;

namespace ConsoleAppATM
{
    //KISS та  YAGNI
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var bank = new Bank { Name = "MyBank" };
            var atm = new AutomatedTellerMachine ();

            var account1 = new Account { CardNumber = "1234567890123456", OwnerName = "Софія Стецюк", Balance = 5000 };
            var account2 = new Account { CardNumber = "9876543210987654", OwnerName = "Роберт Мадлер", Balance = 3000 };

            bank.ATMs.Add(atm);

            string choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Перевірити баланс");
                Console.WriteLine("2. Зняти гроші");
                Console.WriteLine("3. Перевести гроші");
                Console.WriteLine("4. Поповнити рахунок");
                Console.WriteLine("5. Вийти");

                Console.Write("\nОберіть пункт меню: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var balance = atm.CheckBalance(account1);
                        Console.WriteLine($"Баланс: {balance:C}");
                        break;

                    case "2":
                        Console.Write("Введіть суму для зняття: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                        {
                            if (atm.Withdraw(account1, withdrawalAmount))
                            {
                                Console.WriteLine("Гроші знято.");
                            }
                            else
                            {
                                Console.WriteLine("Помилка при знятті грошей.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некоректний ввід.");
                        }
                        break;

                    case "3":
                        Console.Write("Введіть суму для переказу: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal transferAmount))
                        {
                            atm.Transfer(account1, account2, transferAmount);
                            Console.WriteLine("Гроші переказано.");
                        }
                        else
                        {
                            Console.WriteLine("Некоректний ввід.");
                        }
                        break;
                    case "4":
                        Console.Write("Введіть суму для поповнення рахунку: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            atm.Deposit(account1, depositAmount);
                            Console.WriteLine("Рахунок поповнено.");
                        }
                        else
                        {
                            Console.WriteLine("Некоректний ввід.");
                        }
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                Console.ReadKey();

            }
        }
    }
}
