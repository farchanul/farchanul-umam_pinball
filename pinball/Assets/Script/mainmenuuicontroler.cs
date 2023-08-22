using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenuuicontroler : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;


  private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    creditButton.onClick.AddListener(Credit);
    exitButton.onClick.AddListener(ExitGame);
  }

  public void PlayGame()
  {
    SceneManager.LoadScene("pinball");
  }

  public void ExitGame()
  {
    Application.Quit();
  }
  public void Credit(){
    SceneManager.LoadScene("credit");
  }
}
