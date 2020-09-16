using UnityEngine;
public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset= new Vector3(-18,3,5);
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
