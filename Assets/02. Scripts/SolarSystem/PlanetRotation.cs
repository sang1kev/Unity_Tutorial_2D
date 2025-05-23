using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 30f;
    public float revolSpeed = 100f;
    public bool isRevolution = false;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * rotSpeed * Time.deltaTime);
        if (isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolSpeed * Time.deltaTime);
        }
    }
}
