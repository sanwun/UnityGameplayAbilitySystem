using Assets.MyGameplayAbilitySystem.AbilitySystem.GameplayEffects;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using GameplayAbilitySystem.GameplayTags;

public class MeleeAttackAbility
{
    public GameplayTagScriptableObject[] AbilityTags;
    public GameplayTagScriptableObject[] CancelAbilitiesWithTags;
    public GameplayTagScriptableObject[] BlockAbilitiesWithTags;
    public GameplayTagScriptableObject[] ActivationOwnedTags;
    public GameplayTagScriptableObject[] ActivationRequiredTags;
    public GameplayTagScriptableObject[] ActivationBlockedTags;
    public GameplayTagScriptableObject[] SourceRequiredTags;
    public GameplayTagScriptableObject[] SourceBlockedTags;
    public GameplayTagScriptableObject[] TargetRequiredTags;
    public GameplayTagScriptableObject[] TargetBlockedTags;
    public StandardGameplayEffect[] GameplayEffects;
}