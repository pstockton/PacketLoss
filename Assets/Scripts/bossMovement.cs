using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMovement : MonoBehaviour
{
	
	
	public GameObject player;		// The player
	public GameObject waypoint_trigger;	// The location the player will need to be at to trigger event
	public GameObject waypoint;		// The location the boss will move to
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
        if (Vector3.Distance(player.transform.position, waypoint_trigger.transform.position) < wPradius) {
			trigger = true;
		}
		
		// When the trigger event is TRUE, move the enemy towards the player
		if (trigger == true) {
			transform.position = Vector3.MoveTowards(transform.position, waypoint.transform.position, Time.deltaTime * speed);
		}
    }
}
