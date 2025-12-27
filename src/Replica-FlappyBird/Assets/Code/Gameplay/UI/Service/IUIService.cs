using UnityEngine;

namespace Code.Gameplay.UI.Service
{
  public interface IUIService
  {
    void ShowLooseWindow();
    void BindRoot(RectTransform uiRoot);
  }
}