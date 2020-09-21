using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    //access type + The data type + the name + value input
    public float horizantalimput;

    
    void Update()
    {
        horizantalimput = Input.GetAxis("Horizontal");
        
    }
}
