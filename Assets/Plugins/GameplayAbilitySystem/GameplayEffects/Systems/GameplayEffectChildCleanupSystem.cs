/*
 * Created on Wed Dec 11 2019
 *
 * The MIT License (MIT)
 * Copyright (c) 2019 Sahil Jain
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or substantial
 * portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
 * TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */


using GameplayAbilitySystem.Common.Components;
using GameplayAbilitySystem.GameplayEffects._Components;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;

namespace GameplayAbilitySystem.GameplayEffects._Systems {
    [UpdateInGroup(typeof(GameplayEffectGroupUpdateEndSystem))]
    public class GameplayEffectChildCleanupSystem : SystemBase {
        EntityQuery gameplayEffectsPendingRemovalQuery;
        BeginInitializationEntityCommandBufferSystem m_EntityCommandBuffer;

        protected override void OnCreate() {
            m_EntityCommandBuffer = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate() {
            var Ecb = m_EntityCommandBuffer.CreateCommandBuffer().ToConcurrent();
            var GameplayEffectTargetComponents = GetComponentDataFromEntity<GameplayEffectTargetComponent>(true);
            Entities
                .WithNone<GameplayEffectTargetComponent>()
                .ForEach((Entity entity, int entityInQueryIndex, in GameplayEffectActivatedSystemStateComponent _) => {
                    Ecb.DestroyEntity(entityInQueryIndex, entity);
                })
                .WithStoreEntityQueryInField(ref gameplayEffectsPendingRemovalQuery)
                .ScheduleParallel(Dependency);


            Entities
                .ForEach((Entity entity, int entityInQueryIndex, in ParentGameplayEffectEntity parentGE) => {
                    // If the parent gameplay effect no longer exists (because it doesn't have a GameplayEffectTargetComponent),
                    // then delete this
                    if (!GameplayEffectTargetComponents.HasComponent(parentGE)) {
                        Ecb.DestroyEntity(entityInQueryIndex, entity);
                    }

                })
                .WithReadOnly(GameplayEffectTargetComponents)
                .ScheduleParallel(Dependency);


            m_EntityCommandBuffer.AddJobHandleForProducer(Dependency);
        }
    }
}