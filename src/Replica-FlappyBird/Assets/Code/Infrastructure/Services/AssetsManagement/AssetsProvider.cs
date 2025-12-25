using Code.Gameplay.Road;
using UnityEngine;

namespace Code.Infrastructure.Services.AssetsManagement
{
  public class AssetsProvider : IAssetsProvider
  {
    public Segment LoadSegment()
    {
      return Resources.Load<Segment>(AssetPath.Segment);
    }
  }
}