using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ISourceRequiredTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ISourceRequiredTags : IAbilityTagDefinition { }

    public class SourceRequiredTagsComponent : AbilityTagsDefinitionComponent<ISourceRequiredTags> { }
}
