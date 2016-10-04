using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour {

    Vector3 dir;
    public float speed = 5;
    public float gravity = -100;
    CharacterController cc;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
        dir.x = Input.GetAxis("Horz") * speed;
        dir.z = Input.GetAxis("Vert") * speed;

        if (cc.isGrounded)
        {
            dir.y = 0;
        }

        dir.y += gravity * Time.deltaTime;
        cc.Move(dir * Time.deltaTime);
	}
}
