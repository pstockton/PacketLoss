using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
	//Camera mycam = GetComponent<Camera>();
	public GameObject mycam;
	//
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		// Camera follows mouse pointer
		//transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);
		float mouseX = (Input.mousePosition.x / Screen.width ) - 0.5f;
		float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
		transform.localRotation = Quaternion.Euler (new Vector4 (-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }
}
