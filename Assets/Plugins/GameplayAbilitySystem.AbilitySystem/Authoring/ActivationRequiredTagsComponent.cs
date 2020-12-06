using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActivationRequiredTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IActivationRequiredTags : IAbilityTagDefinition { }
    public class ActivationRequiredTagsComponent : AbilityTagsDefinitionComponent<IActivationRequiredTags> { }
}
