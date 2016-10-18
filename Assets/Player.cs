using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    float speed;
    GameObject newInstance;
    public int counter;
    public GameObject leftBorder, rightBorder, upBorder, downBorder;

    // Use this for initialization
    void Start () {
        speed = 10;
        counter = 0;
        //GameObject backGround = GameObject.Find("MyPlane");         
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 delta;

        delta.x = Input.GetAxis("Horz") * Time.deltaTime * speed;
        delta.y = Input.GetAxis("Vert") * Time.deltaTime * speed;
        delta.z = 0; 
        
        transform.position += delta;
        
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 randomVectorPosition;
        //Debug.Log("My Log: " + other.gameObject.name);
        if (other.gameObject.name == "Sphere_1")
        {
            Debug.Log("Object Name: " + other.gameObject.name);
            newInstance = new GameObject();
            randomVectorPosition = new Vector3(Random.Range((leftBorder.transform.position.x + 10), (rightBorder.transform.position.x - 10)), Random.Range((downBorder.transform.position.y + 10), (upBorder.transform.position.y - 10)), 19.5f);
            Debug.Log("Random: "+ randomVectorPosition);
            newInstance = (GameObject)Instantiate(other.gameObject, randomVectorPosition, Quaternion.identity);
            newInstance.name = "Sphere_1";

            Destroy(other.gameObject);
            counter += 1;
            if (counter == 15)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single); // winning condition

            }
            newInstance.SetActive(true);
        }
        else if (other.gameObject.name == "MovingTile")
        {
            Debug.Log("Collision detected");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
            
    }
}
