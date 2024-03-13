using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask5
{
    public class CharacterDirector
    {
        private ICharacterBuilder characterBuilder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            characterBuilder = builder;
        }

        public Character ConstructCharacter()
        {
            return characterBuilder
                .SetHeight(180.0)
                .SetBuild("Athletic")
                .SetHairColor("Brown")
                .SetEyeColor("Blue")
                .SetClothing("Casual")
                .AddInventoryItem("Sword")
                .AddInventoryItem("Shield")
                .Build();
        }

        public Character ConstructEnemy()
        {
            return characterBuilder
                .SetHeight(170.0)
                .SetBuild("Slim")
                .SetHairColor("Black")
                .SetEyeColor("Green")
                .SetClothing("Dark Robe")
                .AddInventoryItem("Poison Dagger")
                .SetEvilDeeds(new List<string> { "Вбивство", "Заговор" })
                .Build();
        }
    }
}
