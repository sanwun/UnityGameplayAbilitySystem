using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ITargetBlockedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ITargetBlockedTags : IAbilityTagDefinition { }

    public class TargetBlockedTagsComponent : AbilityTagsDefinitionComponent<ITargetBlockedTags> { }
}
