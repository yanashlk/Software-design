using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask5
{
    public interface ICharacterBuilder
    {
        public interface ICharacterBuilder
        {
            ICharacterBuilder SetHeight(double height);
            ICharacterBuilder SetBuild(string build);
            ICharacterBuilder SetHairColor(string hairColor);
            ICharacterBuilder SetEyeColor(string eyeColor);
            ICharacterBuilder SetClothing(string clothing);
            ICharacterBuilder AddInventoryItem(string item);
            ICharacterBuilder SetEvilDeeds(List<string> evilDeeds);
            Character Build();
        }


    }
}
