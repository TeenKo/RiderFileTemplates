namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using System;
    using Leopotam.EcsLite;
    using Models;
    using UniGame.LeoEcs.Bootstrap.Runtime.Attributes;
    using UniGame.LeoEcs.ViewSystem.Extensions;

    /// <summary>
    /// System that handles clicking on ${FEATURENAME} buttons to trigger specific actions.
    /// </summary>
 #[[#if ENABLE_IL2CPP
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
#endif]]#
    [Serializable]
    [ECSDI]
    public class ClickTo${FEATURENAME}ButtonsSystem : IEcsInitSystem, IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter _viewFilter;

        public void Init(IEcsSystems systems)
        {
            _world = systems.GetWorld();
            
            _viewFilter = _world
                .ViewFilter<${FEATURENAME}ViewModel>()
                .End();
        }

        public void Run(IEcsSystems systems)
        {
            foreach (var viewEntity in _viewFilter)
            {
                var model = _world.GetViewModel<${FEATURENAME}ViewModel>(viewEntity);
                
                if (!model.click.Take()) continue;
            }
        }
    }
}