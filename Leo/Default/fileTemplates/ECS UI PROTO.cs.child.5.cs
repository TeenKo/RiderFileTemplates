namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Components.Requests;
    using Leopotam.EcsProto;
    using UniGame.LeoEcs.Bootstrap.Runtime.Abstract;
    using UniGame.LeoEcs.Bootstrap.Runtime.Attributes;
    
#[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    [ECSDI]
    public class ${FEATURENAME}Aspect : EcsAspect
    {
        // Represents a request to show the ${FEATURENAME}.
        public ProtoPool<Show${FEATURENAME}Request> Show;
        // Represents a request to hide the ${FEATURENAME}.
        public ProtoPool<Hide${FEATURENAME}Request> Hide;
    }
}