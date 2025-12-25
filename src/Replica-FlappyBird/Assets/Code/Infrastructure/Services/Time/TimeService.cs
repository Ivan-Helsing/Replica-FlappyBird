namespace Code.Infrastructure.Services.Time
{
  public class TimeService : ITimeService
  {
    private bool _paused = true;
    
    public float DeltaTime => !_paused ? UnityEngine.Time.deltaTime : 0f;

    public void StopTime() => _paused = true;
    public void StartTime() => _paused = false;
  }
}