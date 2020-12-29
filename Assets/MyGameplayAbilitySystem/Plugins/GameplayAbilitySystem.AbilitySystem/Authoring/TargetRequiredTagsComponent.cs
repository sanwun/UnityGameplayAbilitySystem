using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ITargetRequiredTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ITargetRequiredTags : IAbilityTagDefinition { }
    public class TargetRequiredTagsComponent : AbilityTagsDefinitionComponent<ITargetRequiredTags> { }
}
