using UnityEngine;

public class SunPlanetLighting : MonoBehaviour {

    public Transform target;

    // Update is called once per frame
    void Update() {
        // Rotate to point towards center (Sun)
        transform.LookAt(2 * transform.position - target.position);
    }
}
