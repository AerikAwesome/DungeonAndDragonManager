using System.Collections.Generic;
using System.Linq;

namespace DungeonAndDragonManager.Models.CharacterModels
{
    public class SkillList
    {
        private List<Skill> Skills { get; set; }

        public SkillList(Dictionary<SkillEnum, Proficiency> proficiencies)
        {
            Skills = new List<Skill> {
                new Skill(SkillEnum.Acrobatics, AbilityEnum.Dexterity, proficiencies[SkillEnum.Acrobatics]),
                new Skill(SkillEnum.AnimalHandling, AbilityEnum.Wisdom, proficiencies[SkillEnum.AnimalHandling]),
                new Skill(SkillEnum.Arcana, AbilityEnum.Intelligence, proficiencies[SkillEnum.Arcana]),
                new Skill(SkillEnum.Athletics, AbilityEnum.Strength, proficiencies[SkillEnum.Athletics]),
                new Skill(SkillEnum.Deception, AbilityEnum.Charisma, proficiencies[SkillEnum.Deception]),
                new Skill(SkillEnum.History, AbilityEnum.Intelligence, proficiencies[SkillEnum.History]),
                new Skill(SkillEnum.Insight, AbilityEnum.Wisdom, proficiencies[SkillEnum.Insight]),
                new Skill(SkillEnum.Intimidation, AbilityEnum.Charisma, proficiencies[SkillEnum.Intimidation]),
                new Skill(SkillEnum.Investigation, AbilityEnum.Intelligence, proficiencies[SkillEnum.Investigation]),
                new Skill(SkillEnum.Medicine, AbilityEnum.Wisdom, proficiencies[SkillEnum.Medicine]),
                new Skill(SkillEnum.Nature, AbilityEnum.Intelligence, proficiencies[SkillEnum.Nature]),
                new Skill(SkillEnum.Perception, AbilityEnum.Wisdom, proficiencies[SkillEnum.Perception]),
                new Skill(SkillEnum.Performance, AbilityEnum.Charisma, proficiencies[SkillEnum.Performance]),
                new Skill(SkillEnum.Persuasion, AbilityEnum.Charisma, proficiencies[SkillEnum.Persuasion]),
                new Skill(SkillEnum.Religion, AbilityEnum.Intelligence, proficiencies[SkillEnum.Religion]),
                new Skill(SkillEnum.SleightOfHand, AbilityEnum.Dexterity, proficiencies[SkillEnum.SleightOfHand]),
                new Skill(SkillEnum.Stealth, AbilityEnum.Dexterity, proficiencies[SkillEnum.Stealth]),
                new Skill(SkillEnum.Survival, AbilityEnum.Wisdom, proficiencies[SkillEnum.Survival])
            };
        }

        public int GetAbilityScore(SkillEnum skillName, AbilityList abilities, int proficiency)
        {
            var skill = Skills.Single(s => s.SkillName == skillName);
            var result = 0;
            if (skill.Proficiency.Proficient)
                result += proficiency;
            if (skill.Proficiency.Expert)
                result += proficiency;
            result += abilities.GetAbilityScore(skill.BaseAbility);

            return result;
        }
    }
    public class Skill
    {
        public SkillEnum SkillName { get; set; }
        public AbilityEnum BaseAbility { get; set; }
        public Proficiency Proficiency { get; set; }

        public Skill(SkillEnum skill, AbilityEnum ability, Proficiency proficiency)
        {
            SkillName = skill;
            BaseAbility = ability;
            Proficiency = proficiency;
        }
    }

    public class Proficiency
    {
        public bool Proficient { get; set; }
        public bool Expert { get; set; }

        public Proficiency(bool proficient, bool expert)
        {
            Proficient = proficient;
            Expert = expert;
        }
    }

    public enum SkillEnum
    {
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SleightOfHand,
        Stealth,
        Survival
    }
}
