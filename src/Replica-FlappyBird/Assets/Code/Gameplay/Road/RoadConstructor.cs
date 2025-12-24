using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Road
{
  public class RoadConstructor : MonoBehaviour
  {
    [SerializeField] private float _lastPositionY;
    [SerializeField] private Segment _segmentPrefab;
    
    private readonly List<Segment> _segments = new(16);

    private void Start()
    {
      for (int i = 0; i < _segments.Count; i++)
      {
        _segments[i].PlaceColumnsAt(RandomPoint());
      }
    }

    private Vector3 RandomPoint() => 
      new(0f, RandomOperator() * _lastPositionY + RandomModificator(), 0f);

    private float RandomModificator() => 
      Random.Range(0, 5f);

    private int RandomOperator()
    {
      int i = Random.Range(0, 1);
      if (i == 0)
        return i - 1;
      return i;
    }
  }
}