using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed= 25.1f;
    private float turnSpeed=40.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    //in this start function I am having the console inform that the van is moving because it has this script
    void Start()
    {
        print("Van Is moving because of PlayerController script");
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward
        transform.Translate(Vector3.forward *Time.deltaTime*speed*forwardInput);
        //Turn the vehicle 
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}