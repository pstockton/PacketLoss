using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint_Move : MonoBehaviour
{
	
	public GameObject[] waypoints;
	int current = 0;
	float rotSpeed;
	public float speed;
	float wPradius = 1;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < wPradius) {
			current++;
			
			// Once the last waypoint is reached, reset back to the start
			//if (current >= waypoints.Length) {
			//	current = 0;
			//}
		}
		
		transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
