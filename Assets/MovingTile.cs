using UnityEngine;
using System.Collections;

public class MovingTile : MonoBehaviour {

    public Player playerObj;
    public float velocity;
    public bool speedIncreased;
    Vector3 delta;

    // Use this for initialization
    void Start () {

        velocity = 10;
        speedIncreased = false;
    }
	
	// Update is called once per frame
	void Update () {
        
        delta = transform.position;

        delta.y += velocity * Time.deltaTime;
            
        transform.position = delta;
        if (transform.position.y >= 10) velocity = (0-velocity);
        else if (transform.position.y <= -12) velocity = Mathf.Abs(velocity);

        if (playerObj.counter > 6 && !speedIncreased)
        {
            if(velocity < 0)    velocity = -20;
            else if(velocity > 0) velocity = 20;

            speedIncreased = true;
        }

        //Debug.Log("V : " + velocity + "total : " + velocity * Time.deltaTime);

    }
}
