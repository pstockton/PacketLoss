using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossCollision : MonoBehaviour
{
	
	int total_hits = 0;
	
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

		// If boss enemy, a certain number of bullets must hit to destroy boss
		if (target.gameObject.tag == "Bullet") {
			Debug.Log("Bullet collision detected");
			if (total_hits >= 5) {
				Destroy(target.gameObject);	// Destroy the bullet
				Destroy(gameObject);	// Destroy boss
			} else {
				Destroy(target.gameObject);	// Destroy bullet
				total_hits += 1;	// Increment boss hit by 1
			}
		}
    }
	
}
