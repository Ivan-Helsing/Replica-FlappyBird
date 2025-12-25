using Code.Gameplay.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI
{
  public class ScoreCounter : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _scoreCount;
    
    private IArbiterService _arbiter;

    [Inject]
    public void Construct(IArbiterService arbiter) => 
      _arbiter = arbiter;

    private void Start() => 
      _scoreCount.text = $"Current Score: {_arbiter.CurrentScore}";

    private void OnTriggerEnter2D(Collider2D other)
    {
      _arbiter.AddScore();
      _scoreCount.text = $"Current Score: {_arbiter.CurrentScore}";
    }
  }
}