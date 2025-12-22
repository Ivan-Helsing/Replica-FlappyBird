using Code.Infrastructure.Services.Coroutines;
using Code.Infrastructure.Services.Scenes;
using Code.Infrastructure.Services.States;
using Zenject;

namespace Code.Infrastructure.Bootstrap
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public override void InstallBindings()
    {
      BindInstaller();
      BindInfrastructureServices();
    }

    public void Initialize()
    {
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    private void BindInstaller() => 
      Container.BindInterfacesAndSelfTo<BootstrapInstaller>().AsSingle();

    private void BindInfrastructureServices()
    {
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
    }
  }
}
