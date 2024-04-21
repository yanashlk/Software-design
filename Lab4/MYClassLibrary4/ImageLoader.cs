using System;
using System.Drawing;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

public class ImageLoader
{
    public Image LoadImage(string href)
    {
        if (IsLocalFile(href))
        {
            return LoadLocalImage(href);
        }
        else
        {
            return LoadNetworkImage(href);
        }
    }

    private bool IsLocalFile(string href)
    {
        // Перевірка чи посилання на локальний файл
        string[] localProtocols = { "file://" }; // Можливо потрібно буде розширити цей список

        // Перевірка за наявності локальних протоколів
        foreach (string protocol in localProtocols)
        {
            if (href.StartsWith(protocol, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        // Якщо не знайдено локальний протокол, перевіряємо розширення файлу
        string extension = Path.GetExtension(href);
        if (!string.IsNullOrEmpty(extension))
        {
            string[] localExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
            foreach (string localExtension in localExtensions)
            {
                if (extension.Equals(localExtension, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
        }

        // Якщо жодна з перевірок не виконалася, вважаємо, що це не локальний файл
        return false;
    }

    private Image LoadLocalImage(string href)
    {
        // Код для завантаження локального зображення
        // Припустимо, що href містить шлях до файлу
        string filePath = new Uri(href).LocalPath;
        return Image.FromFile(filePath);
    }

    private Image LoadNetworkImage(string href)
    {
        // Код для завантаження зображення з мережі
        WebClient client = new WebClient();
        Stream stream = client.OpenRead(href);
        return Image.FromStream(stream);
    }
}