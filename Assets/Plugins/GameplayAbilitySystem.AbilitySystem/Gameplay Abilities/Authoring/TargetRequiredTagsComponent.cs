using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ITargetRequiredTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface ITargetRequiredTags : IAbilityTagDefinition { }

    public class TargetRequiredTagsComponent : AbilityTagsDefinitionComponent<ITargetRequiredTags> { }
}
