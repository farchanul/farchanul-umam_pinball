using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class trigergameover : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider bola;
    public GameObject gameOverCanvas;

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
	    gameOverCanvas.SetActive(true);
    }
  }
}
