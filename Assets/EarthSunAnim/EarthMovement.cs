using UnityEngine;

public class EarthMovement : MonoBehaviour {

    float rotationSpeed = -25.0f;
    float revolutionSpeed = -10.0f;
	
    // Update is called once per frame
    void Update () {
        // Rotation around own axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Revolution around center (Sun)
        transform.RotateAround(Vector3.zero, Vector3.up, revolutionSpeed * Time.deltaTime);
    }
}
