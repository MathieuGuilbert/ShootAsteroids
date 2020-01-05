using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScoreEnd : MonoBehaviour
{
	public Text CurrentText;
	public Text HighText;
	
    // Start is called before the first frame update
    void Start()
    {
		int highscore=PlayerPrefs.GetInt ("highscore", 0);
		int currentscore= gameState.scorePlayer;
		if(highscore<currentscore){
			highscore=currentscore;
			PlayerPrefs.SetInt ("highscore", highscore);
		}
		CurrentText.text = "" + currentscore;
		HighText.text = ""+ highscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
