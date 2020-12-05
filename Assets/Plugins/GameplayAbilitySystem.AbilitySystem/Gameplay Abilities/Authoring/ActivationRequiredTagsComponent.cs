using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationRequiredTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface IActivationRequiredTags : IAbilityTagDefinition { }

    public class ActivationRequiredTagsComponent : AbilityTagsDefinitionComponent<IActivationRequiredTags> { }
}
