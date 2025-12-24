using Code.Gameplay.Providers;
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
    }

    private void BindGameplayServices() => 
      Container.BindInterfacesTo<PlayerProvider>().AsSingle();
  }
}
