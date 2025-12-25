using Code.Gameplay.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Player
{
  public class PlayerCollisions : MonoBehaviour
  {
    private IArbiterService _arbiter;

    [Inject]
    public void Construct(IArbiterService arbiter) => 
      _arbiter = arbiter;

    private void OnCollisionEnter2D(Collision2D collision) => 
      _arbiter.Loosing();
  }
}