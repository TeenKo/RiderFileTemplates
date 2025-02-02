namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using Cysharp.Threading.Tasks;
    using Leopotam.EcsLite;
    using UniGame.LeoEcs.Bootstrap.Runtime;
    using UnityEngine;
    #set($d = $DIR_PATH.substring(7).replace('/', '.'))

    [CreateAssetMenu(menuName = "ECS Features/${FEATURENAME} Feature")]
    public class ${FEATURENAME}Feature : BaseLeoEcsFeature
    {
        public override UniTask InitializeFeatureAsync(IEcsSystems ecsSystems)
        {
            return UniTask.CompletedTask;
        }
    }
}