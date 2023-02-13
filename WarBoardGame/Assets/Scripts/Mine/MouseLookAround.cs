using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    public float rotationX = 0f;
    public float rotationY = 0f;

    public float sensitivity = 15f;

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            rotationY += Input.GetAxis("Mouse X") * sensitivity;
            rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
    }
}