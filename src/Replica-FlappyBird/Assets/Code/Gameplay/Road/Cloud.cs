using UnityEngine;

namespace Code.Gameplay.Road
{
  public class Cloud : MonoBehaviour
  {
    private void FixedUpdate()
    {
      if (transform.position.x > -7f)
        return;

      transform.position = new Vector3(7f, transform.position.y, transform.position.z);
    }
  }
}