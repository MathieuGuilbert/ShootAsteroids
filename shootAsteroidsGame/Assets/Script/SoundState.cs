using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundState : MonoBehaviour
{
	public static SoundState Instance;
	public AudioClip playerShotSound;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
	{
         Instance = this;
    }
	
	public void touchButtonSound()
	{
		MakeSound(playerShotSound);
	}
	
	/// Play a sound
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
