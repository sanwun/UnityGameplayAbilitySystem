using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IBlockAbilitiesWithTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IBlockAbilitiesWithTags : IAbilityTagDefinition { }

    public class BlockAbilitiesWithTagsComponent : AbilityTagsDefinitionComponent<IBlockAbilitiesWithTags> { }
}
