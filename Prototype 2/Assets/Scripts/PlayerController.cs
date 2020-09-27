using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float speed = 25.1f;
    float horizontalInput;
    public float xRange = 19.5f;
    
    public GameObject projectilePrefab;
    void Start()
    {
        print("player moves, left and right to a limited axis according to playercontroller script test");
        print("player instantiates prefab (projectilePrefab) into scene) ");
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);

        if (transform.position.x < -xRange)
        {
            transform.position =new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x > xRange)
        { 
            transform.position =new Vector3(xRange, transform.position.y,transform.position.z); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
//For some reason I have to define transform position of z or else the player will move and stick to the other side of the screen