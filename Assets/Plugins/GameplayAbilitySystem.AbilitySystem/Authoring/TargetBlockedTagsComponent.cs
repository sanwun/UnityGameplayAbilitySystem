using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ITargetBlockedTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ITargetBlockedTags : IAbilityTagDefinition { }
    public class TargetBlockedTagsComponent : AbilityTagsDefinitionComponent<ITargetBlockedTags> { }
}
