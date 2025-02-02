namespace ${DIR_PATH.substring(7).replace('/', '.')}
{
    using Cysharp.Threading.Tasks;
    using Leopotam.EcsProto;
    using UniGame.LeoEcs.Bootstrap.Runtime;
    using UnityEngine;
    #set($d = $DIR_PATH.substring(7).replace('/', '.'))

    [CreateAssetMenu(menuName = "Proto Features/${FEATURENAME} Feature")]
    public class ${FEATURENAME}Feature : BaseLeoEcsFeature
    {
        public sealed override UniTask InitializeAsync(IProtoSystems ecsSystems)
        {
            return UniTask.CompletedTask;
        }
    }
}