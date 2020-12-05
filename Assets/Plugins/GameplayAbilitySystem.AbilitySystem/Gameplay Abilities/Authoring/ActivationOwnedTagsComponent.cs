using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationOwnedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface IActivationOwnedTags : IAbilityTagDefinition { }

    public class ActivationOwnedTagsComponent : AbilityTagsDefinitionComponent<IActivationOwnedTags> { }
}
