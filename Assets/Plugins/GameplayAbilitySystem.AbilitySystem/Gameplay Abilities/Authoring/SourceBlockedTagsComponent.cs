using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ISourceBlockedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface ISourceBlockedTags : IAbilityTagDefinition { }

    public class SourceBlockedTagsComponent : AbilityTagsDefinitionComponent<ISourceBlockedTags> { }
}
