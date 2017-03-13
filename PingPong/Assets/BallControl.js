#pragma strict

function Start () {
    var randomNumber = Random.Range(0,2);
    if(randomNumber <= 0.5)
    {
        //Debug.Log("shoot right");
        GetComponent.<Rigidbody2D>().AddForce(new Vector2(80,10));
    }
    else
    {
        //Debug.Log("shoot left");
        GetComponent.<Rigidbody2D>().AddForce(new Vector2(-80,-10));

    }

}

function OnCollisionEnter2D (colInfo : Collision2D) {
    if(colInfo.collider.tag == "Player")
    {
        Debug.Log("work");
        //var velY = rigidbody2D.velocity.y;
        GetComponent.<Rigidbody2D>().velocity.y = GetComponent.<Rigidbody2D>().velocity.y/2 + colInfo.collider.GetComponent.<Rigidbody2D>().velocity.y/3;
    }


}