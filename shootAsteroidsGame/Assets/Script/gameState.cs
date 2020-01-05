using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameState : MonoBehaviour
{
	public static gameState Instance;
	public static int scorePlayer; //This variable is static in order to print it at the end of the game
	
	// Start is called before the first frame update
    void Start()
    {
        scorePlayer=0;
	}
	
	void Awake(){
         Instance = this;
		//DontDestroyOnLoad(transform.root.gameObject); //Removed because it caused a lot of errors and alerts. The goal was to keep the value of the score, but the same objective has been achieved by creating a static value on line 9
     }
	
    void Update(){
		GameObject.FindWithTag ("scoreLabel").GetComponent<Text>().text = "" + scorePlayer;
	}
	public void addScorePlayer(int toAdd) {
		scorePlayer += toAdd;
	}
	public int getScorePlayer(){
		return scorePlayer;
	}

}