using Code.Gameplay.Providers;
using Code.Gameplay.Road.Factory;
using Code.Gameplay.Services;
using Code.Gameplay.UI.Service;
using Code.Infrastructure.Services.AssetsManagement;
using Code.Infrastructure.Services.Coroutines;
using Code.Infrastructure.Services.Scenes;
using Code.Infrastructure.Services.States;
using Zenject;

namespace Code.Infrastructure.Bootstrap
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize() => 
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();

    public override void InstallBindings()
    {
      BindInstaller();
      BindInfrastructureServices();
      BindGameplayServices();
    }

    private void BindInstaller() => 
      Container.BindInterfacesAndSelfTo<BootstrapInstaller>().FromInstance(this).AsSingle();

    private void BindInfrastructureServices()
    {
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
      Container.Bind<IAssetsProvider>().To<AssetsProvider>().AsSingle();
      Container.Bind<ISegmentFactory>().To<SegmentFactory>().AsSingle();
    }

    private void BindGameplayServices()
    {
      Container.BindInterfacesTo<PlayerProvider>().AsSingle();
      Container.Bind<IUIService>().To<UIService>().AsSingle();
      Container.Bind<IArbiterService>().To<ArbiterService>().AsSingle();
    }
  }
}
