namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Cysharp.Threading.Tasks;
    using Models;
    using TMPro;
    using UniGame.LeoEcs.ViewSystem.Converters;
    using UniGame.Rx.Runtime.Extensions;
    using UnityEngine.UI;

#[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    public class ${FEATURENAME}View : EcsUiView<${FEATURENAME}ViewModel>
    {
        public TextMeshProUGUI text;
        public Button button;
        
        protected override UniTask OnInitialize(${FEATURENAME}ViewModel model)
        {
            this.Bind(button, model.click)
                .Bind(model.text, text);
            
            return base.OnInitialize(model);
        }
    }
}