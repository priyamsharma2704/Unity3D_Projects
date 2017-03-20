using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement move;
	//public GameManager gamemanager; 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("Hit");
            move.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
        }
    }
}
