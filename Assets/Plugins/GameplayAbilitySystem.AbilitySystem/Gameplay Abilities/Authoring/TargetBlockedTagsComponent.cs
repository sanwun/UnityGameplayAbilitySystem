using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ITargetBlockedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface ITargetBlockedTags : IAbilityTagDefinition { }

    public class TargetBlockedTagsComponent : AbilityTagsDefinitionComponent<ITargetBlockedTags> { }
}
