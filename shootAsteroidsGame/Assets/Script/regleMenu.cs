using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This code was inspired by this video: https://www.youtube.com/watch?v=pbeB9NsaoPs

public class regleMenu : MonoBehaviour
{
	public GameObject RegleMenuUI;
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
		Time.timeScale=0;
		RegleMenuUI.SetActive(true);
		isPaused=true; //needed for the usage of the butt
	}
	public void DeactivateMenu()
	{
		Time.timeScale=1;
		RegleMenuUI.SetActive(false);
		isPaused=false;
	}
}
