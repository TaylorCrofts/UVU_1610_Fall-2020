using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.1f;
    private float horizontalInput;
    public float xRange = 10.00f;
    void Start()
    {
        print("player moves, left and right to a limited axiss according to playercontroller script test");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //Turn the Farmer side to side 
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
       
        if (transform.position.x < -xRange)
        {
            transform.position =new Vector3(-xRange, 0,0);
        }
        if (transform.position.x > xRange)
        { 
            transform.position =new Vector3(xRange, 0,0);
        }
    }
}
