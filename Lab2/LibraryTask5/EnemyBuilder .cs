using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask5
{
   public class EnemyBuilder : ICharacterBuilder
{
    private Character character = new Character();

    public ICharacterBuilder SetHeight(double height)
    {
        character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        character.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        character.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
        character.EyeColor = eyeColor;
        return this;
    }

    public ICharacterBuilder SetClothing(string clothing)
    {
        character.Clothing = clothing;
        return this;
    }

    public ICharacterBuilder AddInventoryItem(string item)
    {
        character.Inventory.Add(item);
        return this;
    }

    // Спеціальний метод для ворога
    public EnemyBuilder SetEvilDeeds(List<string> evilDeeds)
    {
        character.EvilDeeds = evilDeeds;
        return this;
    }

    public Character Build()
    {
        return character;
    }
}
}
