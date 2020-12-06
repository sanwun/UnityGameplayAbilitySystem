using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationBlockedTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IActivationBlockedTags : IAbilityTagDefinition { }
    public class ActivationBlockedTagsComponent : AbilityTagsDefinitionComponent<IActivationBlockedTags> { }
}
