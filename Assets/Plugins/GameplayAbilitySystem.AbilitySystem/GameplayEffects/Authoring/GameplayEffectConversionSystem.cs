using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects
{
    public abstract class GameplayEffectConversionSystem<TGameplayEffect, TGameplayEffectBlob> : GameObjectConversionSystem
    where TGameplayEffect : ScriptableObject
    where TGameplayEffectBlob : struct, IGameplayEffectBlob
    {
        private Dictionary<TGameplayEffect, BlobAssetReference<TGameplayEffectBlob>> _GameplayEffectBlobDict = new Dictionary<TGameplayEffect, BlobAssetReference<TGameplayEffectBlob>>();
        protected override void OnUpdate()
        {
            var gameplayEffectSOs = Resources.LoadAll<TGameplayEffect>("Gameplay Effects");

            BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp);

            for (var i = 0; i < gameplayEffectSOs.Length; i++)
            {
                var gameplayEffectSO = gameplayEffectSOs[i];
                BlobAssetReference<TGameplayEffectBlob> reference = ConvertToBlobAsset(ref blobBuilder, gameplayEffectSO);
                _GameplayEffectBlobDict[gameplayEffectSO] = reference;
            }

            blobBuilder.Dispose();
        }

        protected abstract BlobAssetReference<TGameplayEffectBlob> ConvertToBlobAsset(ref BlobBuilder builder, TGameplayEffect gameplayEffect);
        public bool GetBlob(TGameplayEffect gameplayEffect, out BlobAssetReference<TGameplayEffectBlob> blobAssetReference)
        {
            return !_GameplayEffectBlobDict.TryGetValue(gameplayEffect, out blobAssetReference);
        }

    }


}


