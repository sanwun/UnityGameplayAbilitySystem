using GameplayAbilitySystem.AbilitySystem;
using Unity.Entities;
using UnityEngine;

[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<IAssetTags>.Component))]
namespace GameplayAbilitySystem.AbilitySystem
{
    public interface IAssetTags : IAbilityTagDefinition { }
    public class AssetTagsComponent : AbilityTagsDefinitionComponent<IAssetTags> { }
}
