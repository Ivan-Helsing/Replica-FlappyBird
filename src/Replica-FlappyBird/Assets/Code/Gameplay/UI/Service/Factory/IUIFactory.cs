using Code.Gameplay.UI.Windows;
using UnityEngine;

namespace Code.Gameplay.UI.Service.Factory
{
  public interface IUIFactory
  {
    LoosingWindow CreateLoosingWindow(RectTransform uiRoot);
  }
}