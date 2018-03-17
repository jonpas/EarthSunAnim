using UnityEngine;

public class CameraController : MonoBehaviour {

    private static float movementSpeed = 1.0f;
    private static float mouseX = 0.0f;
    private static float mouseY = 0.0f;

    // Update is called once per frame
    void Update() {
        movementSpeed = Mathf.Max(movementSpeed += Input.GetAxis("Mouse ScrollWheel"), 0.0f);
        transform.position += (transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical") + transform.up * Input.GetAxis("Depth")) * movementSpeed;
        if (Input.GetMouseButton(1)) {
            mouseX = -Input.GetAxis("Mouse Y");
            mouseY = Input.GetAxis("Mouse X");
        } else {
            mouseX = 0.0f;
            mouseY = 0.0f;
        }
        transform.eulerAngles += new Vector3(mouseX, mouseY, Input.GetAxis("Rotation"));
    }
}
