using Code.Gameplay.Road.Factory;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Code.Gameplay.Road
{
  public class RoadConstructor : MonoBehaviour
  {
    private Segment[] _segments = new Segment[2];
    private int _currentSegment;
    private ISegmentFactory _segmentFactory;

    private const float MaxY = 3.5f;

    [Inject]
    public void Construct(ISegmentFactory segmentFactory) =>
      _segmentFactory = segmentFactory;

    private void Start()
    {
      _segments[0] = _segmentFactory.CreateSegment(at: new Vector3(4, 0, 0), transform);
      _segments[0].PlaceColumnsAt(RandomYPoint());
      
      _segments[1] = _segmentFactory.CreateSegment(at: new Vector3(8, 0, 0), transform);
      _segments[1].PlaceColumnsAt(RandomYPoint());
    }

    private void FixedUpdate()
    {
      if (_segments[_currentSegment].transform.position.x > -4f)
        return;

      _segments[_currentSegment].transform.position = new Vector3(4f, 0, 0);
      _segments[_currentSegment].PlaceColumnsAt(RandomYPoint());

      if (_currentSegment == 1)
        _currentSegment = 0;
      else
        _currentSegment++;
    }

    private Vector3 RandomYPoint() => 
      new(0f, RandomizeY(), 0f);

    private float RandomizeY()
    {
      float y = Random.Range(-MaxY, MaxY);

        return y;
    }
  }
}