using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posShip : MonoBehaviour
{
	
	private Vector3 rightTopCameraBorder;
	private Vector3 leftTopCameraBorder;
	private Vector3 rightBottomCameraBorder;
	private Vector3 leftBottomCameraBorder;
	
	private Vector3 siz;
	
    // Start is called before the first frame update
    void Start()
    {
       // 0,1    1,1
	   // 0,0    1,0
	   
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
        leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
		rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
		leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)); 
    }

    // Update is called once per frame
    void Update()
    {
		
		siz.x=gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		siz.y=gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
		
		
		/*
			Positionnement du vaisseau contre le bord gauche de l'écran
		*/
		gameObject.transform.position = new Vector3(leftTopCameraBorder.x+(siz.x/2),transform.position.y,transform.position.z);
		
		
		/*
			Si la position en Y de notre vaisseau est inférieure à la limite basse de l'ecran on repositionne le vaisseau en bas de l'ecran
		*/
		if(transform.position.y < leftBottomCameraBorder.y+(siz.y/2))
			gameObject.transform.position = new Vector3(transform.position.x,leftBottomCameraBorder.y + (siz.y/2),transform.position.z);
		
		/*
			Si la position en Y de notre vaisseau est superieure à la limite haute de l'ecran on repositionne le vaisseau en haut de l'ecran
		*/
		if(transform.position.y > leftTopCameraBorder.y-(siz.y/2))
			gameObject.transform.position = new Vector3(transform.position.x,leftTopCameraBorder.y - (siz.y/2),transform.position.z);
		
    }
}
