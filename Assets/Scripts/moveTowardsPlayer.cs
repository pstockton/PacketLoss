using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsPlayer : MonoBehaviour
{
	public GameObject player;
	public GameObject waypoint;
	public float speed;
	float wPradius = 1;
	public bool trigger = false;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Detect when the player object reaches the waypoint
		// When the player object reaches the waypoint, set the trigger event to be TRUE
        if (Vector3.Distance(player.transform.position, waypoint.transform.position) < wPradius) {
			trigger = true;
		}
		
		// When the trigger event is TRUE, move the enemy towards the player
		if (trigger == true) {
			transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);
		}
	}
}

