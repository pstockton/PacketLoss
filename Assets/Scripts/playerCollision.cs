using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
	
	//public GameObject healthbar;
	//public health other;
	int total_hits = 0;
	int packetloss = 0;	// Calculate % packet loss
	
    // Start is called before the first frame update
    void Start()
    {
        //other.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	// Check to see if the bullet collided with an "Enemy" tag or "Boss" tag
	void OnCollisionEnter(Collision target)
	{
		if (target.gameObject.tag == "Enemy") {
			//Destroy(target.gameObject);	// Destroy enemy
			total_hits += 1;		// Take 1 damage
			packetloss = total_hits * 20;	// Calculate percentage based on 20% per hit
			Destroy(target.gameObject);	// Destroy bullet
			//healthbar.Slider.value;
			//healthbar = GameObject.Find("healthbar");
			//other.decHealth();
			////////GameObject healthbar = GameObject.Find("Canvas").GetComponent<Canvas>().Find("healthbar").GetComponent<Health>();
			FindObjectOfType<Canvas>().transform.GetChild(0).GetComponent<health>().decHealth();
			Debug.Log("Enemy collision detected, PacketLoss = " + packetloss + "%");
			//collisionTime = Time.time;
			
			if (total_hits >= 5){
				Debug.Log("GAME OVER!");
			}
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

