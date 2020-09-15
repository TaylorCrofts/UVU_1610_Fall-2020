using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    //Player is a variable of GameObject that allows me to have one game object do something because of another without having it be parented
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -12);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position +offset;
    }
}