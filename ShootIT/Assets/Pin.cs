using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {

	// Use this for initialization
    private bool isPinned = false;
	public float speed = 20f;
	public Rigidbody2D rb;
	
	// Update is called once per frame
	void Update () {
        if(!isPinned)
		rb.MovePosition (rb.position + Vector2.up * speed * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            col.GetComponent<Rotator>().speed *= -1;
            isPinned = true;
        }

        else if (col.tag == "Pin")
        {
            //Debug.Log("End Game");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
