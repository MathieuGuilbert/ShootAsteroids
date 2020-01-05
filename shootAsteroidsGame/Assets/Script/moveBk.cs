using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is moving the background
public class moveBk : MonoBehaviour
{
    private Vector3 leftBottomCameraBorder;
    public float positionRestartX = 46.102F;
    private Vector3 siz;

    // Start is called before the first frame update
    void Start()
    {
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0);
        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        // If the backgound exits the screen
        // Set the X position with the original backGround3 X position
        if (transform.position.x<leftBottomCameraBorder.x - (siz.x / 2) )
		{
            transform.position = new Vector3(positionRestartX,transform.position.y,transform.position.z);
        }
    }
}
