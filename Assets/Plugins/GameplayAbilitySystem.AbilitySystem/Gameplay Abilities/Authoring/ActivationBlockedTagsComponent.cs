using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationBlockedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IActivationBlockedTags : IAbilityTagDefinition { }

    public class ActivationBlockedTagsComponent : AbilityTagsDefinitionComponent<IActivationBlockedTags> { }
}
