using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickPlay : MonoBehaviour
{
	public void onClick(){
		Debug.Log("Cliked Play");
		Destroy(transform.root.gameObject);
		SceneManager.LoadScene("GameScene");
	}
}
