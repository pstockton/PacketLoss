using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
	
	int total_hits = 0;
	
	// Setup enemy hit sound audio clip
	 public AudioSource audioSource;
	 public AudioClip clip;
	 public float volume = 0.5f;
	 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	// Check to see if the bullet collided with an "Enemy" tag or "Boss" tag
	void OnCollisionEnter(Collision target)
	{
		if (target.gameObject.tag == "Enemy") {
			Debug.Log("Bullet collision detected");
			//Destroy(target.gameObject);	// Destroy enemy
			audioSource.PlayOneShot(clip, volume);	// Play enemy hit sound
			Destroy(gameObject);	// Destroy bullet
			//collisionTime = Time.time;
		}
		
		// If boss enemy, a certain number of bullets must hit to destroy boss
		if (target.gameObject.tag == "Boss") {
			Debug.Log("Bullet collision detected");
			if (total_hits >= 5) {
				Destroy(target.gameObject);	// Destroy the boss
				Destroy(gameObject);	// Destroy bullet
			} else {
				Destroy(gameObject);	// Destroy bullet
				total_hits += 1;	// Increment boss hit by 1
			}
		}
    }
	
}
