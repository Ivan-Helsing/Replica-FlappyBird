using UnityEngine;

namespace Code.Gameplay.Road
{
  public class SegmentMovement : MonoBehaviour
  {
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
      transform.Translate(_direction * _speed);
    }
  }
}