using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationRequiredTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IActivationRequiredTags : IAbilityTagDefinition { }

    public class ActivationRequiredTagsComponent : AbilityTagsDefinitionComponent<IActivationRequiredTags> { }
}
