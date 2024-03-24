using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using MYClassLibrary2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Створення героя-воїна з декораторами інвентаря
        Hero warrior = new Warrior();
        warrior = new ClothingDecorator(warrior);
        warrior = new WeaponDecorator(warrior);
        warrior = new ArtifactDecorator(warrior);

        // Виведення інформації про героя-воїна
        warrior.ShowInfo();

        // Створення героя-мага з декораторами інвентаря
        Hero mage = new Mage();
        mage = new WeaponDecorator(mage);
        mage = new ArtifactDecorator(mage);

        // Виведення інформації про героя-мага
        mage.ShowInfo();

        // Створення героя-паладина з декораторами інвентаря
        Hero paladin = new Paladin();
        paladin = new ClothingDecorator(paladin);
        paladin = new WeaponDecorator(paladin);

        // Виведення інформації про героя-паладина
        paladin.ShowInfo();
    }
}