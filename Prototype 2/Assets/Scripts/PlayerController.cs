using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float speed = 25.1f;
    private float horizontalInput;
    public float xRange = 19.5f;
    void Start()
    {
        print("player moves, left and right to a limited axis according to playercontroller script test");
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //Turn the Farmer side to side 
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
       
        if (transform.position.x < -xRange)
        {
            transform.position =new Vector3(-xRange, 0,transform.position.z);
        }
        if (transform.position.x > xRange)
        { 
            transform.position =new Vector3(xRange, 0,transform.position.z); 
        }
    } 
}
//For some reason I have to define transform position of z or else the player will move and stick to the other side of the screen