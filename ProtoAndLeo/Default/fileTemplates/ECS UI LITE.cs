namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using Components.Requests;
    using Cysharp.Threading.Tasks;
    using Leopotam.EcsLite;
    using Models;
    using Systems;
    using UniGame.LeoEcs.Bootstrap.Runtime;
    using UniGame.LeoEcs.ViewSystem.Extensions;
    using UnityEngine;
    using Leopotam.EcsLite.ExtendedSystems;
    #set($d = $DIR_PATH.substring(7).replace('/', '.'))

    [CreateAssetMenu(menuName = "ECS Features/Ui/${FEATURENAME} Feature")]
    public class ${FEATURENAME}Feature : BaseLeoEcsFeature
    {
        public override UniTask InitializeFeatureAsync(IEcsSystems ecsSystems)
        {
            // System that shows the ${FEATURENAME}.
            ecsSystems.Add(new Show${FEATURENAME}System());
            
            // System that handles clicking on ${FEATURENAME} buttons to trigger specific actions.
            ecsSystems.Add(new ClickTo${FEATURENAME}ButtonsSystem());
            
            // Close View
            ecsSystems.CloseOn<Hide${FEATURENAME}Request, ${FEATURENAME}ViewModel>();
            // Deleted used Hide${FEATURENAME}Request
            ecsSystems.DelHere<Hide${FEATURENAME}Request>();
            
            return UniTask.CompletedTask;
        }
    }
}