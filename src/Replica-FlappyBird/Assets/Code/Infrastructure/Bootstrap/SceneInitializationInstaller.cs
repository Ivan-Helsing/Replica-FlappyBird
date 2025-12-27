using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Bootstrap
{
  public class SceneInitializationInstaller : MonoInstaller
  {
    [SerializeField] private LevelInitializer Initializer;

    public override void InstallBindings()
    {
      Container.BindInterfacesTo<LevelInitializer>().FromInstance(Initializer).AsSingle();
    }
  }
}