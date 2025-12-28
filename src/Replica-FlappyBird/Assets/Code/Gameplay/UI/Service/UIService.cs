using Code.Gameplay.UI.Service.Factory;
using UnityEngine;

namespace Code.Gameplay.UI.Service
{
  public class UIService : IUIService
  {
    private readonly IUIFactory _factory;
    private RectTransform _uiRoot;
    private bool _loosingStateEnabled;

    public UIService(IUIFactory factory) => 
      _factory = factory;

    public void BindRoot(RectTransform uiRoot) => 
      _uiRoot = uiRoot;

    public void RestartLoosingState() => 
      _loosingStateEnabled = false;

    public void ShowLooseWindow()
    {
      if(!_loosingStateEnabled)
      {
        _factory.CreateLoosingWindow(_uiRoot);
        _loosingStateEnabled = true;
      }
    }
  }
}