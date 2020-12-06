using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ITargetRequiredTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ITargetRequiredTags : IAbilityTagDefinition { }

    public class TargetRequiredTagsComponent : AbilityTagsDefinitionComponent<ITargetRequiredTags> { }
}
