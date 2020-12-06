using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IActiveGrantedTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IActiveGrantedTags : IAbilityTagDefinition { }

    public class ActiveGrantedTagsComponent : AbilityTagsDefinitionComponent<IActiveGrantedTags> { }
}
