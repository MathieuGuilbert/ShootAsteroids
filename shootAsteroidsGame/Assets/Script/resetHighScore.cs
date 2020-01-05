using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetHighScore : MonoBehaviour
{
	
	public void resetScore(){
		PlayerPrefs.SetInt("highscore", 0);
		Debug.Log("Highscore reset");
	}
	
}
