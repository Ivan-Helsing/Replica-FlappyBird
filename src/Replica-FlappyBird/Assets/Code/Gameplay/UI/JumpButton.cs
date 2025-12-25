using Code.Gameplay.Providers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI
{
  public class JumpButton : MonoBehaviour
  {
    [SerializeField] protected Button _button;
    private IPlayerProvider _player;

    [Inject]
    public void Construct(IPlayerProvider playerProvider) => 
      _player = playerProvider;

    private void Awake() => 
      _button.onClick.AddListener(BirdBurst);

    private void BirdBurst() => 
      _player.PlayerMovement.FlyingBurst();
  }
}