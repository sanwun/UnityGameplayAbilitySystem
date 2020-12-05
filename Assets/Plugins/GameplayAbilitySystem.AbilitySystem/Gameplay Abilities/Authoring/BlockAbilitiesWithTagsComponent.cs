using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IBlockAbilitiesWithTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface IBlockAbilitiesWithTags : IAbilityTagDefinition { }

    public class BlockAbilitiesWithTagsComponent : AbilityTagsDefinitionComponent<IBlockAbilitiesWithTags> { }
}
