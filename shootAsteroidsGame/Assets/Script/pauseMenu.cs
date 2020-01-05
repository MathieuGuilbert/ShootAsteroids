using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This code was inspired by this video: https://www.youtube.com/watch?v=pbeB9NsaoPs

public class pauseMenu : MonoBehaviour
{
	public GameObject PauseMenuUI;
	public static bool isPaused;
	
    // Start is called before the first frame update
    void Start()
    {
        isPaused=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
				isPaused = !isPaused;
		}
		
		if(isPaused){
			ActivateMenu();
		}else{
			DeactivateMenu();
		}
    }
	
	public void ActivateMenu()
	{
		//AudioListener.pause=true; //If we wanted the music to stop when the game is posed
		Time.timeScale=0;
		PauseMenuUI.SetActive(true);
		isPaused=true;
	}
	public void DeactivateMenu()
	{
		//AudioListener.pause=false;
		Time.timeScale=1;
		PauseMenuUI.SetActive(false);
		isPaused=false;
	}
}
