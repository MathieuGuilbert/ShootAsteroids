using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private GameObject[] asteroids;    
	private GameObject[] stars;
    private Vector3 rightTopCameraBorder;
    private Vector3 leftTopCameraBorder;
    private Vector3 rightBottomCameraBorder;
    private Vector3 leftBottomCameraBorder;
    private Vector3 tmpPos;
	private int nbAsteroids=6;  //We start at 6 asteroids 
    private int cpt=0;
    private int cptStars=0;
	private float timer = 0.0f;

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
		//We need to verify if the game is paused
		if(!pauseMenu.isPaused){ 
		
			if(nbAsteroids<10){ // our Asteroid limit is 10 at the same time
				timer+=Time.deltaTime;
				if(timer>30){ //every 30 seconds we add an asteroid.
					nbAsteroids++;
					Debug.Log("nbAsteroids = "+nbAsteroids);
					timer=0;
				}
			}
			
			cpt++;
			cptStars++;
			asteroids = GameObject.FindGameObjectsWithTag("asteroid");
			stars = GameObject.FindGameObjectsWithTag("star");
			
			
			if (asteroids.Length < nbAsteroids && cpt>10)
			{
				float random = Random.Range(leftBottomCameraBorder.y, leftTopCameraBorder.y);
				tmpPos = new Vector3(rightBottomCameraBorder.x, random, transform.position.z);					
				GameObject gY = Instantiate (Resources.Load ("AsteroidSP"), tmpPos, Quaternion.identity) as GameObject;
				cpt = 0;
			}
			if(cptStars>70){  //we add a star every 60 frames
				float random = Random.Range(leftBottomCameraBorder.y, leftTopCameraBorder.y);
				tmpPos = new Vector3(rightBottomCameraBorder.x, random, transform.position.z);
				GameObject sY = Instantiate (Resources.Load("starSP"), tmpPos, Quaternion.identity) as GameObject;
				cptStars = 0;
			}
		}
    }
}
