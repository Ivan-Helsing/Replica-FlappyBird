using System;
using System.Collections;
using Code.Infrastructure.Services.Coroutines;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.Services.Scenes
{
  public class SceneLoader : ISceneLoader
  {
    private ICoroutineRunner _coroutineRunner;

    public void LoadScene(string sceneName, Action onLoaded = null)
    {
      _coroutineRunner.StartCoroutine(Load(sceneName, onLoaded));
    }

    private IEnumerator Load(string sceneName, Action onLoaded = null)
    {
      if (SceneManager.GetActiveScene().name == sceneName)
      {
        onLoaded?.Invoke();
        yield break;
      }

      AsyncOperation nextScene = SceneManager.LoadSceneAsync(sceneName);

      while (!nextScene.isDone)
        yield return null;

      onLoaded?.Invoke();
    }
  }
}