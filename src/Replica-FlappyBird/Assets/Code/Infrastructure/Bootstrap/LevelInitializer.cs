using Code.Gameplay.UI.Service;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Bootstrap
{
  public class LevelInitializer : MonoBehaviour, IInitializable
  {
    [SerializeField] private RectTransform _uiRoot;
    private IUIService _uiFactory;

    [Inject]
    public void Construct(IUIService uiFactory)
    {
      _uiFactory = uiFactory;
    }
    
    public void Initialize()
    {
      _uiFactory.BindRoot(_uiRoot);
    }
  }
}