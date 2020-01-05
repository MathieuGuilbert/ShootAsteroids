using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//script from https://www.youtube.com/watch?v=ST7BAqV-1ow

public class moveShipTouch : MonoBehaviour
{
	private Vector3 touchPosition;
	private Rigidbody2D rb;
	private Vector3 direction;
	private float moveSpeed=25f;
	
    // Start is called before the first frame update
    void Start()
    {
		rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
			if(!EventSystem.current.IsPointerOverGameObject(touch.fingerId)){ //To make sure the ship does not move when the player clicks on a button
				
				touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
				touchPosition.x = transform.position.x;
				touchPosition.z = 0;
				direction = (touchPosition - transform.position);
				rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

				if (touch.phase == TouchPhase.Ended)
					rb.velocity = Vector2.zero;
			}
			
        }
    }
}
