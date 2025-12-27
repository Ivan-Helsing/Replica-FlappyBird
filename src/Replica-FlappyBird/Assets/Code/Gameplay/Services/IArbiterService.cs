using Code.Gameplay.Player;

namespace Code.Gameplay.Services
{
  public interface IArbiterService
  {
    int HighScore { get; }
    int CurrentScore { get; }
    void LoadHighScore();
    void AddScore();
    void Loosing();
    void SaveHighScore();
    void SetPlayerMovement(PlayerMovement playerMovement);
  }
}