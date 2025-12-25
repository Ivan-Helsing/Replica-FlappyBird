using Code.Infrastructure.Services.Time;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Road
{
  public class SegmentMovement : MonoBehaviour
  {
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;
    private ITimeService _time;

    [Inject]
    public void Construct(ITimeService time) => 
      _time = time;

    private void Update() => 
      transform.Translate(_direction * _speed * _time.DeltaTime);
  }
}