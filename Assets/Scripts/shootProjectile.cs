using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Source: https://answers.unity.com/questions/953132/make-projectile-shoot-the-direction-im-looking.html

public class shootProjectile : MonoBehaviour
{
     public GameObject prefab;
	 
	 // Setup shooting sound audio clip
	 public AudioSource audioSource;
	 public AudioClip clip;
	 public float volume = 0.5f;
	 
     public float fireRate = 1;
     private float nextFire = 0.0F;
     public float speed = 30;
	 
	void Start () {
		//prefab = Resources.Load ("projectile") as GameObject;
    }
	 
   void Update()
   {
      if (Input.GetMouseButtonDown(0)) {  // && Time.time > nextFire
            nextFire = Time.time + fireRate;
            GameObject projectile = Instantiate(prefab)as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward *2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
			audioSource.PlayOneShot(clip, volume);	// Play shooting sound
 
 
		}
   }
   /*
	//void OnTriggerEnter(Collider other)
	void OnCollisionEnter(Collision target)
	{
		if (target.gameObject.tag == "Bullet") {
			Debug.Log("Bullet collision detected");
			Destroy(target.gameObject);
			//collisionTime = Time.time;
		}
    }*/
	
/*	
	public GameObject ProjectilePrefab;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{
			GameObject Bullet = Instantiate(ProjectilePrefab, transform.position, transform.rotation) as GameObject;
			Bullet.transform.position = Bullet.transform.forward;
		}
    }
*/
}
