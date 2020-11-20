using System.Linq;
using GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects;
using Unity.Collections;
using Unity.Entities;

public class MyGameplayEffectConversionSystem : GameplayEffectConversionSystem<StandardGameplayEffect, StandardGameplayEffectBlob>
{
    protected override BlobAssetReference<StandardGameplayEffectBlob> ConvertToBlobAsset(ref BlobBuilder builder, StandardGameplayEffect gameplayEffect)
    {
        ref StandardGameplayEffectBlob gameplayEffectBlob = ref builder.ConstructRoot<StandardGameplayEffectBlob>();
        gameplayEffectBlob.AssetTags = gameplayEffect.AssetTags.Select(x => x.Tag).ToArray();
        gameplayEffectBlob.GrantedTags = gameplayEffect.GrantedTags.Select(x => x.Tag).ToArray();
        gameplayEffectBlob.OngoingTagRequirements = gameplayEffect.OngoingTagRequirements.Select(x => x.Tag).ToArray();
        gameplayEffectBlob.ApplicationTagRequirements = gameplayEffect.ApplicationTagRequirements.Select(x => x.Tag).ToArray();
        gameplayEffectBlob.RemoveGameplayEffectsWithTags = gameplayEffect.RemoveGameplayEffectsWithTags.Select(x => x.Tag).ToArray();
        gameplayEffectBlob.GrantedApplicationImmunityTags = gameplayEffect.GrantedApplicationImmunityTags.Select(x => x.Tag).ToArray();
        gameplayEffectBlob.Duration = gameplayEffect.Duration;
        gameplayEffectBlob.AttributeModifiers = gameplayEffect.AttributeModifiers;
        gameplayEffectBlob.EffectId = gameplayEffect.EffectId;
        gameplayEffectBlob.GroupEffectId = gameplayEffect.GroupEffectId;
        gameplayEffectBlob.Period = gameplayEffect.Period;
        var reference = builder.CreateBlobAssetReference<StandardGameplayEffectBlob>(Allocator.Persistent);
        return reference;
    }
}

