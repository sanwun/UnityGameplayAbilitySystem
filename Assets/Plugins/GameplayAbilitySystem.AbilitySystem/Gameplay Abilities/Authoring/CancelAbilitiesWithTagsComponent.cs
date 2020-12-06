using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ICancelAbilitiesWithTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem
{
    public interface ICancelAbilitiesWithTags : IAbilityTagDefinition { }

    public class CancelAbilitiesWithTagsComponent : AbilityTagsDefinitionComponent<ICancelAbilitiesWithTags> { }
}
