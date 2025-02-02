namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Components.Requests;
    using Leopotam.EcsLite;
    using UniGame.LeoEcs.Bootstrap.Runtime.Abstract;
    
#[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    public class ${FEATURENAME}Aspect : EcsAspect
    {
        // Represents a request to show the ${FEATURENAME}.
        public EcsPool<Show${FEATURENAME}Request> Show;
        // Represents a request to hide the ${FEATURENAME}.
        public EcsPool<Hide${FEATURENAME}Request> Hide;
    }
}