using UnityEngine;

namespace Code.Gameplay.Road.Factory
{
  public interface ISegmentFactory
  {
    Segment CreateSegment(Vector3 at, Transform transform);
  }
}