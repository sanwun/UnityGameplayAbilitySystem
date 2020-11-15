using System;
using System.ComponentModel;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [Serializable]
    public struct MyPlayerAttributes
    {
        public float[] Attributes;
        public const int ATTRIBUTE_SIZE = 9;

        public float this[EMyPlayerAttribute attribute]
        {
            get { return Attributes[(int)attribute]; }
            set { Attributes[(int)attribute] = value; }
        }

        public static MyPlayerAttributes Create(float Health = 0,
                                                float MaxHealth = 0,
                                                float Mana = 0,
                                                float MaxMana = 0,
                                                float Speed = 0,
                                                float PhysicalAttackDamage = 0,
                                                float MagicAttackDamage = 0,
                                                float PhysicalDefense = 0,
                                                float MagicDefense = 0)
        {
            var newAttributes = new MyPlayerAttributes()
            {
                Attributes = new float[ATTRIBUTE_SIZE] { Health, MaxHealth, Mana, MaxMana, Speed, PhysicalAttackDamage, MagicAttackDamage, PhysicalDefense, MagicDefense }
            };

            return newAttributes;
        }
    }


}
