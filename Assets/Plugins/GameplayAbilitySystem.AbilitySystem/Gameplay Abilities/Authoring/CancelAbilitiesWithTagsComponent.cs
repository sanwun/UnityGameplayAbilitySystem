using Unity.Entities;
using GameplayAbilitySystem.AbilitySystem.Abilities;
[assembly: RegisterGenericComponentType(typeof(AbilityTagsDefinitionComponent<ICancelAbilitiesWithTags>.Component))]

namespace GameplayAbilitySystem.AbilitySystem.Abilities
{
    public interface ICancelAbilitiesWithTags : IAbilityTagDefinition { }

    public class CancelAbilitiesWithTagsComponent : AbilityTagsDefinitionComponent<ICancelAbilitiesWithTags> { }
}
