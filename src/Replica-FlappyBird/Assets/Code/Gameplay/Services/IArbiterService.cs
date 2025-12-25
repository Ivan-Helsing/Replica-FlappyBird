namespace Code.Gameplay.Services
{
  public interface IArbiterService
  {
    int MaxScore { get; }
    int CurrentScore { get; }
    void InitMaxScore();
    void SaveMaxScore();
    void AddScore();
    void Loosing();
  }
}