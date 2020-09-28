using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds= -10f;
    
    void Update()
    {
        if (transform.position.z>topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
