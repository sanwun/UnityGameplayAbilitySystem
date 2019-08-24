﻿using System.Collections.Generic;
using GameplayAbilitySystem.Abilities.AbilityActivations;
using Unity.Entities;
using UnityEngine;

[DisallowMultipleComponent]
[RequiresEntityConversion]
public class FireballAuthoringComponent : MonoBehaviour, IConvertGameObjectToEntity {
    [SerializeField] GameObject Prefab;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
        var system = World.Active.GetExistingSystem<FireAbilityActivationSystem>();
        system.Prefab = Prefab;
    }

}
