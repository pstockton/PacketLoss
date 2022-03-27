using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script for changing light color and/or intensity
// Red color used: R=255, G=0, B=3, A=255 : Hex=FF0003
// Teal color used: R=0, G=216, B=255, A=255 : Hex=00D8FF
public class lightChange : MonoBehaviour
{
	public GameObject light_source;
	public float r_start = 0;
	public float g_start = 0;
	public float b_start = 0;
	public float a_start = 255;
	float teal_r_end = 0;
	float teal_g_end = 216;
	float teal_b_end = 255;
	float teal_a_end = 255;
	
	public float speed = 50;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (r_start < teal_r_end) {
			r_start += Time.deltaTime * speed;
		}
		
		if (g_start < teal_g_end) {
			g_start += Time.deltaTime * speed;
		}
		
		if (b_start < teal_g_end) {
			b_start += Time.deltaTime * speed;
		}
		Color32 temp = new Color (r_start, g_start, b_start, a_start);
		
		//light_source.GetComponent<Renderer>().material.color = new Color32((byte)(r_start * 255), (byte) (g_start * 255), (byte)(b_start * 255), (byte)(a_start * 255));
		
        //transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
