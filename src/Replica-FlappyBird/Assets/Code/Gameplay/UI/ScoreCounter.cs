using TMPro;
using UnityEngine;

namespace Code.Gameplay.UI
{
  public class ScoreCounter : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _timerText;
    private float _currentTime;

    private void Update()
    {
      _currentTime += Time.deltaTime;
      _timerText.text = $"{_currentTime}";
    }
  }
}