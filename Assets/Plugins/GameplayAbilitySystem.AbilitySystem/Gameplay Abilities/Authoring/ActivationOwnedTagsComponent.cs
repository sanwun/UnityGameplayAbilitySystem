using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationOwnedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IActivationOwnedTags : IAbilityTagDefinition { }

    public class ActivationOwnedTagsComponent : AbilityTagsDefinitionComponent<IActivationOwnedTags> { }
}
