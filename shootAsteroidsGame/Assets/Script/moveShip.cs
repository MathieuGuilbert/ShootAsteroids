using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float v = Input.GetAxis("Vertical");
		//Debug.Log("v "+v);
		float h = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(h,v)*25;
    }
	
	/* Trying to use inputs from the phone
	public void goUp(){
		Debug.Log("Cliked Up");
        gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(1,0)*25;
	}
	
	public void goDown(){
		Debug.Log("Cliked Down");
        gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(-1,0)*2500;
	}
	*/
}
