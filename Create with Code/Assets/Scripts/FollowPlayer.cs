using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 6, -12);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position +offset;
    }
}