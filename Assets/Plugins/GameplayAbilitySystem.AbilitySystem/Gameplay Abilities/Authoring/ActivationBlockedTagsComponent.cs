using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationBlockedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface IActivationBlockedTags : IAbilityTagDefinition { }

    public class ActivationBlockedTagsComponent : AbilityTagsDefinitionComponent<IActivationBlockedTags> { }
}
