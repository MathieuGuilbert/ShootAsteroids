using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepMusic : MonoBehaviour
{
	private static keepMusic Instance;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
		if(Instance==null){ //we want the music to start only when nothing is playing
			Instance=this; 
		
			DontDestroyOnLoad(this.gameObject);
		}else{
			Destroy(this.gameObject);
		}
    }
}
