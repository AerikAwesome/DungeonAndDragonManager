using System.Collections.Generic;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class AbilityList
    {
        private Dictionary<AbilityEnum, int> Abilities { get; }
        public int Strength { get => Abilities[AbilityEnum.Strength]; set => Abilities[AbilityEnum.Strength] = value; }
        public int Dexterity { get => Abilities[AbilityEnum.Dexterity]; set => Abilities[AbilityEnum.Dexterity] = value; }
        public int Constitution { get => Abilities[AbilityEnum.Constitution]; set => Abilities[AbilityEnum.Constitution] = value; }
        public int Intelligence { get => Abilities[AbilityEnum.Intelligence]; set => Abilities[AbilityEnum.Intelligence] = value; }
        public int Wisdom { get => Abilities[AbilityEnum.Wisdom]; set => Abilities[AbilityEnum.Wisdom] = value; }
        public int Charisma { get => Abilities[AbilityEnum.Charisma]; set => Abilities[AbilityEnum.Charisma] = value; }

        public AbilityList(int str, int dex, int con, int inte, int wis, int cha)
        {
            Abilities = new Dictionary<AbilityEnum, int>()
            {
                {AbilityEnum.Strength, str },
                {AbilityEnum.Dexterity, dex },
                {AbilityEnum.Constitution, con },
                {AbilityEnum.Intelligence, inte },
                {AbilityEnum.Wisdom, wis },
                {AbilityEnum.Charisma, cha },
            };
        }

        public int GetAbilityScore(AbilityEnum ability)
        {
            return Abilities[ability];
        }
    }

    public enum AbilityEnum
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }
}
