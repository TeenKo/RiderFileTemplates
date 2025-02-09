namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Aspects;
    using Components.Requests;
    using Leopotam.EcsProto;
    using Leopotam.EcsProto.QoL;
    using Models;
    using UniGame.LeoEcs.Bootstrap.Runtime.Attributes;
    using UniGame.LeoEcs.ViewSystem.Aspects;
    using UniGame.LeoEcs.ViewSystem.Extensions;
    using UniModules.UniCore.Runtime.Utils;
    using UniModules.UniGame.UiSystem.Runtime;
    using Views;

    /// <summary>
    /// System that shows the ${FEATURENAME}.
    /// </summary>
 #[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    [ECSDI]
    public class Show${FEATURENAME}System : IProtoRunSystem
    {
        private ProtoWorld _world;
        private ${FEATURENAME}Aspect _aspect;
        private ViewAspect _viewAspect;

        private ProtoIt _requestFilter = It
            .Chain<Show${FEATURENAME}Request>()
            .End();

        private ProtoIt _viewFilter = ViewIt
            .ViewChain<${FEATURENAME}ViewModel>()
            .End();

        public void Run()
        {
            foreach (var requestEntity in _requestFilter)
            {
                if (!_viewFilter.IsEmpty())
                {
                    _world.DelEntity(requestEntity);
                    continue;
                }

                ref var showScreenRequest = ref _aspect.Show.Get(requestEntity);

                if (showScreenRequest.ShowIsStarted) continue;

                var newViewEntity = _world.NewEntity();
                ref var viewRequest = ref _viewAspect.CreateLayoutView.Add(newViewEntity);
                viewRequest.View = nameof(${FEATURENAME}View);
                viewRequest.LayoutType = ViewType.Screen.ToStringFromCache();

                showScreenRequest.ShowIsStarted = true;
            }
        }
    }
}