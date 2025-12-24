using UnityEngine;

namespace Code.Gameplay.Road
{
  public class Segment : MonoBehaviour
  {
    [SerializeField] private GameObject _columns;

    public void PlaceColumnsAt(Vector3 position) => 
      transform.position = position;
  }
}