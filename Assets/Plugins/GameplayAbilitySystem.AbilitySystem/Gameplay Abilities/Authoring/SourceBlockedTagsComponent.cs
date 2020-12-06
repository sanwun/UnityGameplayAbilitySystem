using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ISourceBlockedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ISourceBlockedTags : IAbilityTagDefinition { }

    public class SourceBlockedTagsComponent : AbilityTagsDefinitionComponent<ISourceBlockedTags> { }
}
