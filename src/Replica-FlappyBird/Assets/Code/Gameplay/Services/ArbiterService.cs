using Code.Gameplay.UI.Service;
using Code.Infrastructure.Services.Time;
using UnityEngine;

namespace Code.Gameplay.Services
{
  public class ArbiterService : IArbiterService
  {
    private const string HighScoreKey = "HighScore";
    private int _currentScore;
    private int _highScore;

    private readonly IUIService _ui;
    private readonly ITimeService _time;

    public ArbiterService(IUIService ui, ITimeService time)
    {
      _ui = ui;
      _time = time;
    }

    public int HighScore => _highScore;
    public int CurrentScore => _currentScore;

    public void LoadHighScore()
    {
      _highScore = PlayerPrefs.GetInt(key: HighScoreKey, 0);
      Debug.Log("Loading high score");
    }

    public void SaveHighScore()
    {
      if (_highScore < _currentScore)
      {
        _highScore = _currentScore;
        PlayerPrefs.SetInt(HighScoreKey, _currentScore);
        Debug.Log("Saving high score");
      }
    }

    public void AddScore() =>
      _currentScore++;

    public void Loosing()
    {
      SaveHighScore();
      _time.StopTime();
      _ui.ShowLooseWindow();
    }
  }
}