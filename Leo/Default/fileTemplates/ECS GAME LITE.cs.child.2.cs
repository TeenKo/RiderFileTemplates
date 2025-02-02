namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;

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
    public struct ${FEATURENAME}Component
    {
    }
}