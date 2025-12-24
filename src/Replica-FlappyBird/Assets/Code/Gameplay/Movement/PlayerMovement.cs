using UnityEngine;

namespace Code.Gameplay.Movement
{
  public class PlayerMovement : MonoBehaviour
  {
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _force;

    public void FlyingBurst()
    {
      _rigidbody.linearVelocity = Vector2.up * _force;
    }
  }
}