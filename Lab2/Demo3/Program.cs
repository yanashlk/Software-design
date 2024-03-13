using MYClassLibrary2;
internal class Program
{
    private static void Main(string[] args)
    {
        // Приклад використання
        Authenticator auth1 = Authenticator.Instance;
        Authenticator auth2 = Authenticator.Instance;

        // Перевірка, чи це той самий екземпляр
        Console.WriteLine($"{nameof(auth1)} == {nameof(auth2)}: {auth1 == auth2}");

        // Використання для аутентифікації
        auth1.Authenticate("admin", "admin");
        auth2.Authenticate("user", "password");
    }
}
