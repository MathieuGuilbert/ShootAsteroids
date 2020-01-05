using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionShip : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "asteroid")
        {
            Debug.Log("Le vaisseau a rencontrer "+collider.tag);

            if(GameObject.FindGameObjectWithTag("life5"))
                GameObject.FindGameObjectWithTag("life5").AddComponent< fadeOut >();
            else if (GameObject.FindGameObjectWithTag("life4"))
                GameObject.FindGameObjectWithTag("life4").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life3"))
                GameObject.FindGameObjectWithTag("life3").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life2"))
                GameObject.FindGameObjectWithTag("life2").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life1")){
                GameObject.FindGameObjectWithTag("life1").AddComponent<fadeOut>();
				SceneManager.LoadScene("GameOverScene");
			}
        }
    }
}
