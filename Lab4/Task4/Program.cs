using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        // Створюємо екземпляр класу ImageLoader
        ImageLoader imageLoader = new ImageLoader();

        // Приклад використання:
        string localImagePath = "D:\\МОЄ\\Just photo\\photo_2023-12-01_18-55-03.jpg";
        string networkImagePath = "https://ztu.edu.ua/img/mainpage/header/photo1.jpg";

        Image localImage = imageLoader.LoadImage(localImagePath);
        Image networkImage = imageLoader.LoadImage(networkImagePath);
    }
}