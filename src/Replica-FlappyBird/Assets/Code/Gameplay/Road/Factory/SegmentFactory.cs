using Code.Infrastructure.Services.AssetsManagement;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Road.Factory
{
  public class SegmentFactory : ISegmentFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetsProvider _assets;

    public SegmentFactory(IInstantiator instantiator, IAssetsProvider assets)
    {
      _instantiator = instantiator;
      _assets = assets;
    }

    public Segment CreateSegment(Vector3 at, Transform transform)
    {
      var segment = _instantiator.InstantiatePrefabForComponent<Segment>(_assets.LoadSegment(), transform);
      segment.transform.position = at;
      
      return segment;
    }
  }
}