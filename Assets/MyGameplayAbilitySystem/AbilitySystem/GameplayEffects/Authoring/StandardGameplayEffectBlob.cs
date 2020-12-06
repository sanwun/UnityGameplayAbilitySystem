using GameplayAbilitySystem.AbilitySystem;
using GameplayAbilitySystem.GameplayTags;
using MyGameplayAbilitySystem;

public struct StandardGameplayEffectBlob : IGameplayEffectBlob
{
    public uint EffectId;
    public uint GroupEffectId;
    public DurationPolicy Duration;
    public Modifiers<EMyPlayerAttribute, EMyAttributeModifierOperator>[] AttributeModifiers;
    public PeriodPolicy Period;
    public GameplayTag[] AssetTags;
    public GameplayTag[] GrantedTags;
    public GameplayTag[] OngoingTagRequirements;
    public GameplayTag[] ApplicationTagRequirements;
    public GameplayTag[] RemoveGameplayEffectsWithTags;
    public GameplayTag[] GrantedApplicationImmunityTags;
}

