using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    public float rotationX = 10f;
    public float rotationY = 0f;
    public float rotationZ = 0f;

    public float sensitivity = 1f;

    void Update()
    {
        if (Input.GetMouseButton(1)) {
            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
    }
}