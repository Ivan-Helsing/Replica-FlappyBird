using Code.Gameplay.UI.Service;
using UnityEngine;

namespace Code.Gameplay.Services
{
  public class ArbiterService : IArbiterService
  {
    private const string MaxScoreKey = "MaxScore";
    private int _currentScore;
    private int _maxScore;
    
    private readonly IUIService _ui;

    public ArbiterService(IUIService ui)
    {
      _ui = ui;
    }

    public int MaxScore => _maxScore;
    public int CurrentScore => _currentScore;

    public void InitMaxScore() => 
      PlayerPrefs.SetInt(key: MaxScoreKey, _maxScore);

    public void SaveMaxScore()
    {
      if(_maxScore < _currentScore)
        PlayerPrefs.SetInt(MaxScoreKey, _currentScore);
    }

    public void AddScore() => 
      _currentScore ++;

    public void Loosing() => 
      _ui.ShowLooseWindow();
  }
}