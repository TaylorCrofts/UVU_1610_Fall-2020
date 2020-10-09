
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fetchRate = 1f;
    private float nextFetch = 0f;

    void Update()
    { 
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time >nextFetch)
        {
            nextFetch = Time.time + fetchRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}