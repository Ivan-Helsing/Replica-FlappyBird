using Code.Gameplay.Providers;
using Code.Gameplay.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Player
{
  public class PlayerMovement : MonoBehaviour, IPlayerMovement
  {
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _force;

    private bool _disabled;

    [Inject]
    public void Construct(IPlayerProviderSetter providerSetter, IArbiterService arbiter)
    {
      providerSetter.SetPlayerMovement(this);
      arbiter.SetPlayerMovement(this);
    }

    public void FlyingBurst()
    {
      if (!_disabled)
        _rigidbody.linearVelocity = Vector2.up * _force;
    }

    public void ActivateGravity() =>
      _rigidbody.gravityScale = 1f;

    public void DisableMovement() =>
      _disabled = true;
  }
}