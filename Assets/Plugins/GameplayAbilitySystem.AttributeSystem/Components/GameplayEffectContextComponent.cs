using Unity.Entities;

namespace GameplayAbilitySystem.AttributeSystem
{
    public struct GameplayEffectContextComponent : IComponentData
    {
        public Entity Target;
        public Entity Source;
    }
}
