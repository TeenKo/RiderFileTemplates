namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Models;
    using UniGame.LeoEcs.ViewSystem.Converters;

#[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    public class ${FEATURENAME}View : EcsUiView<${FEATURENAME}ViewModel>
    {

    }
}