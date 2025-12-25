using Code.Gameplay.Providers;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Player
{
  public class PlayerMovement : MonoBehaviour, IPlayerMovement
  {
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _force;

    [Inject]
    public void Construct(IPlayerProviderSetter providerSetter) => 
      providerSetter.SetPlayerMovement(this);

    public void FlyingBurst() => 
      _rigidbody.linearVelocity = Vector2.up * _force;

    public void ActivateGravity() => 
      _rigidbody.gravityScale = 1f;
  }
}