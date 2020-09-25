using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0 * Time.deltaTime, 50, Space.Self);
    }
}