namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Aspects;
    using Leopotam.EcsProto;
    using Leopotam.EcsProto.QoL;
    using UniGame.LeoEcs.Bootstrap.Runtime.Attributes;

    /// <summary>
    /// ADD COMMENTS
    /// </summary>
#[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    [ECSDI]
    public class ${FEATURENAME}System : IProtoRunSystem
    {
        private ProtoWorld _world;

        public void Run()
        {
            
        }
    }
}