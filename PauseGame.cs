using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
    public Transform canvas;
    public Transform pauseMenu;
  //  public Transform soundsMenu;
  //  public Transform videoSettingsMenu;
   // public Transform controlsMenu;
  //  public Transform Player;
 



	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

		if (Input.GetKeyDown(KeyCode.A))
		{
			ExitGame();
		}

	}
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);

              //  soundsMenu.gameObject.SetActive(false);
             //   videoSettingsMenu.gameObject.SetActive(false);
             //   controlsMenu.gameObject.SetActive(false);
            }
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
         //   Player.GetComponent<FirstPersonController>().enabled = false;
            //saveGame = gameObject.GetComponent<SaveGame>();
          //  saveGame.SaveGameSettings(false);
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
          //  Player.GetComponent<FirstPersonController>().enabled = true;
        }
    }

	public void ExitGame () //This function will be used on our "Yes" button in our Quit menu

	{
		Application.Quit(); //this will quit our game. Note this will only work after building the game

	}


   
        }
    

