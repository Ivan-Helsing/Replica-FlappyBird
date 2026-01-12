using UnityEngine;

namespace Code.Gameplay.Animation
{
  public class PlayerAnimator : MonoBehaviour
  {
    private readonly int _flyingHash = Animator.StringToHash("Fly");
    
    [SerializeField] private Animator _animator;
    
    public void PlayFly() => _animator.SetTrigger(_flyingHash);
  }
}