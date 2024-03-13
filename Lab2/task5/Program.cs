using LibraryTask5;
internal class Program
{
    private static void Main(string[] args)
    {
        // Створення героя за допомогою HeroBuilder
        var heroBuilder = new HeroBuilder();
        var heroDirector = new CharacterDirector(heroBuilder);
        Character hero = heroDirector.ConstructCharacter();
        hero.DisplayInfo();

        // Створення першого ворога за допомогою EnemyBuilder
        var enemyBuilder = new EnemyBuilder();
        Character enemy = enemyBuilder
            .SetEvilDeeds(new List<string> { "Крадіжка", "Обман" })
            .Build();
        enemy.DisplayInfo();

    }
}
