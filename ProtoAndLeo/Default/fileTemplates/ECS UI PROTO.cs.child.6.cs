namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using UniGame.Runtime.Common;
    using UniGame.UiSystem.Runtime;
    using UniRx;
    
#[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    public class ${FEATURENAME}ViewModel : ViewModelBase
    {
        public ReactiveProperty<string> text = new();
        public SignalValueProperty<bool> click = new();
    }
}