using Code.Gameplay.Services;
using Code.Infrastructure.Services.States;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.Windows
{
  public class LoosingWindow : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _highScore;
    [SerializeField] private Button _restartButton;
    
    private IArbiterService _arbiter;
    private IRestartStateLauncher _restartLauncher;

    [Inject]
    public void Construct(IArbiterService arbiterService, IRestartStateLauncher restart)
    {
      _arbiter = arbiterService;
      _restartLauncher = restart;
    }

    private void Awake()
    {
      _restartButton.onClick.AddListener(GameRestart);
    }

    private void GameRestart() => 
      _restartLauncher.MoveToRestartState();

    public void ShowScores()
    {
      _currentScore.text = $"Current Score: {_arbiter.CurrentScore}";
      _highScore.text = $"High Score: {_arbiter.HighScore}";
    }
  }
}