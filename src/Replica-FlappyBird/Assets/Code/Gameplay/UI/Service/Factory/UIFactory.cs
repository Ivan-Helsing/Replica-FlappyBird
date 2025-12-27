using Code.Gameplay.UI.Windows;
using Code.Infrastructure.Services.AssetsManagement;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.Service.Factory
{
  public class UIFactory : IUIFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetsProvider _assets;

    public UIFactory(IInstantiator instantiator, IAssetsProvider assets)
    {
      _instantiator = instantiator;
      _assets = assets;
    }

    public LoosingWindow CreateLoosingWindow(RectTransform uiRoot)
    {
      LoosingWindow window = _instantiator.InstantiatePrefabForComponent<LoosingWindow>(_assets.LoadLoosingWindow(), uiRoot);
      window.ShowScores();
      
      return window;
    }
  }
}