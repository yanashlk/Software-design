namespace MYClassLibrary4
{
    // Клас SmartTextReader для читання вмісту текстового файлу та перетворення на двомірний масив
    public class SmartTextReader
    {
        public char[,] ReadTextFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int maxLength = lines[0].Length;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                    maxLength = line.Length;
            }

            char[,] textArray = new char[lines.Length, maxLength];

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < maxLength; j++)
                {
                    if (j < lines[i].Length)
                        textArray[i, j] = lines[i][j];
                    else
                        textArray[i, j] = ' ';
                }
            }

            return textArray;
        }
    }
}
