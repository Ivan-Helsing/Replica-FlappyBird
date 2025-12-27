using Code.Gameplay.Services;
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

    [Inject]
    public void Construct(IArbiterService arbiterService)
    {
      _arbiter = arbiterService;
    }

    public void ShowScores()
    {
      _currentScore.text = $"Current Score: {_arbiter.CurrentScore}";
      _highScore.text = $"High Score: {_arbiter.HighScore}";
    }
  }
}