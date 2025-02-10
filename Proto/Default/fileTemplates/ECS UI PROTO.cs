namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using Components.Requests;
    using Cysharp.Threading.Tasks;
    using Leopotam.EcsProto;
    using Models;
    using Systems;
    using UniGame.LeoEcs.Bootstrap.Runtime;
    using UniGame.LeoEcs.Shared.Extensions;
    using UniGame.LeoEcs.ViewSystem.Extensions;
    using UnityEngine;
    using Leopotam.EcsLite.ExtendedSystems;
    #set($d = $DIR_PATH.substring(7).replace('/', '.'))

    [CreateAssetMenu(menuName = "Proto Features/Ui/${FEATURENAME} Feature")]
    public class ${FEATURENAME}Feature : BaseLeoEcsFeature
    {
        public sealed override UniTask InitializeAsync(IProtoSystems ecsSystems)
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