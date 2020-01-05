using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShoot : MonoBehaviour
{
    private Vector3 rightTopCameraBorder;
    private Vector3 leftTopCameraBorder;
    private Vector3 rightBottomCameraBorder;
    private Vector3 leftBottomCameraBorder;
    private Vector3 siz;

    // Start is called before the first frame update
    void Start()
    {
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1,0)*11;

        siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        float random = Random.Range(leftBottomCameraBorder.y, leftTopCameraBorder.y);

        if (transform.position.x > rightBottomCameraBorder.x + (siz.x / 2))
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
		gameState.Instance.addScorePlayer(1);
        if (collider.tag == "asteroid")
        {
            Debug.Log("Une balle a rencontrer " + collider.tag);
            collider.gameObject.AddComponent<fadeOut>();
            Destroy(gameObject);
        }
    }
}
