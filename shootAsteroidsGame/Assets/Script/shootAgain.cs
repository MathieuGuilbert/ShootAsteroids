using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAgain : MonoBehaviour
{
    private Vector3 siz;

    void Start()
    {
        
    }

    void Update()
    {

        //if space key is pressed
        bool sp = Input.GetKeyDown(KeyCode.Space);
        if (sp)
        {
			shoot();
        }
    }
	
	public void shoot(){
        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
		
		SoundState.Instance.touchButtonSound();
		//get the position of the shoot using the ship position
        Vector3 tmpPos = new Vector3(transform.position.x + siz.x, transform.position.y, transform.position.z);
        //instantiate shootOrange
        GameObject gY = Instantiate(Resources.Load("shootorange"), tmpPos, Quaternion.identity) as GameObject;
	}
}
