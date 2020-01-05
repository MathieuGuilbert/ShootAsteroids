using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStars : MonoBehaviour
{
	private Vector3 leftBottomCameraBorder;
	private Vector3 siz;
	
    // Start is called before the first frame update
    void Start()
    {
		leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)); 
    }

    // Update is called once per frame
    void Update()
    {
		gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(-1,0);
		
		siz.x=gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		siz.y=gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
		
		//float random= Random.Range(leftBottomCameraBorder.y,leftTopCameraBorder.y);

        if (transform.position.x < leftBottomCameraBorder.x + (siz.x / 2))
            Destroy(gameObject);
    }
}
