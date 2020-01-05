using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickMenu : MonoBehaviour
{
    public void onClick(){
		Debug.Log("Cliked Menu");
		Destroy(transform.root.gameObject);
		SceneManager.LoadScene("MenuScene");
	}
}
