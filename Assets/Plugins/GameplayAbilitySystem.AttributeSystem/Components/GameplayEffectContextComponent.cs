using Unity.Entities;

namespace GameplayAbilitySystem.AttributeSystem.Components
{
    public struct GameplayEffectContextComponent : IComponentData
    {
        public Entity Target;
        public Entity Source;
    }

    public struct GameplayEffectIdentifierComponent : ISharedComponentData
    {
        public uint Id;
    }
}
