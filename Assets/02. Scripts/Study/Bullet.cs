using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 50f;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }
    // transform.forward  = local기준 forward
    // Vector3.forward = world기준 forward
}
