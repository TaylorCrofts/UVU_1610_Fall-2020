using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed= 20.1f;
    public float turnSpeed=5;

    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        print("Is moving");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward
        transform.Translate(Vector3.forward *Time.deltaTime*speed*forwardInput);
        //Turn the vehicle 
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
