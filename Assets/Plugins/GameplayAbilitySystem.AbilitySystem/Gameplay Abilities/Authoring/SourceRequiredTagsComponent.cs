using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ISourceRequiredTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface ISourceRequiredTags : IAbilityTagDefinition { }

    public class SourceRequiredTagsComponent : AbilityTagsDefinitionComponent<ISourceRequiredTags> { }
}
