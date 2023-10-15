using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_script : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject pauseMenuUI;
  [SerializeField] GameObject settingsmenu2;
  [SerializeField] GameObject settingsmenu3;
  void Update ()
  {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
          if(GameIsPaused)
          {
              settingsmenu2.SetActive(false);
              settingsmenu3.SetActive(true);
              Resume();
          }else
          {
              Pause();
          }
      }
  }
  public void Resume ()
  {
      pauseMenuUI.SetActive(false);
      GameIsPaused = false;
  }
  public void Pause()
  {
      pauseMenuUI.SetActive(true);
      GameIsPaused = true;
  }
}
