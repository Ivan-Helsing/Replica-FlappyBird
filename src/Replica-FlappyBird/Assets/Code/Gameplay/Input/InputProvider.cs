using Code.Gameplay.Providers;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Code.Gameplay.Input
{
  public class InputProvider : MonoBehaviour
  {
    private IPlayerProvider _playerProvider;

    [Inject]
    public void Construct(IPlayerProvider provider) => 
      _playerProvider = provider;

    public void OnBurst(InputValue value) => 
      _playerProvider.PlayerMovement.FlyingBurst();
  }
}