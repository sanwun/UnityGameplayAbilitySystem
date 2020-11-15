using System;
using System.ComponentModel;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [Serializable]
    public struct MyPlayerAttributes
    {
        public float Health;
        public float MaxHealth;
        public float Mana;
        public float MaxMana;
        public float Speed;
        public float BaseAttackDamage;
        public float MagicAttackDamage;
        public float Defense;
    }
}
