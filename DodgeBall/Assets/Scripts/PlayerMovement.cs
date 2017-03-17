using UnityEngine;
//using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    //public float upForce = 20000f;
    // Use this for initialization
	void Start () {
        //Debug.Log("nfiebofifaf");
        //rb.AddForce(0, 00, 200);
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) 
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
	
	}
}
