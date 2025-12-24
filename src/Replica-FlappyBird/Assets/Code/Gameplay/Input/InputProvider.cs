using Code.Gameplay.Movement;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Gameplay.Input
{
  public class InputProvider : MonoBehaviour
  {
    [SerializeField] private PlayerMovement _playerMovement;

    public void OnBurst(InputValue value)
    {
      _playerMovement.FlyingBurst();
    }
  }
}