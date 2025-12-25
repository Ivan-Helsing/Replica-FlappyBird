using Code.Gameplay.Providers;
using Code.Infrastructure.Services.Time;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI
{
  public class StartingButton : MonoBehaviour
  {
    [SerializeField] protected Button _button;
    private IPlayerProvider _player;
    private ITimeService _timeService;

    [Inject]
    public void Construct(IPlayerProvider playerProvider, ITimeService timeService)
    {
      _player = playerProvider;
      _timeService = timeService;
    }

    private void Awake() => 
      _button.onClick.AddListener(StartGame);

    private void StartGame()
    {
      _timeService.StartTime();
      _player.PlayerMovement.ActivateGravity();
      _player.PlayerMovement.FlyingBurst();
      _button.onClick.RemoveAllListeners();
      Destroy(gameObject);
    }
  }
}