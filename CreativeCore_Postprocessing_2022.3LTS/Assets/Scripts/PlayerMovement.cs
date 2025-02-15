using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] float moveSpeed;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime;

        float movementY = Input.GetAxis("Vertical") * Time.deltaTime;
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime;

        transform.Rotate(0, mouseX * rotationSpeed, 0, Space.World);

        Vector3 movement = (transform.forward * movementY + transform.right * movementX) * moveSpeed;
        transform.Translate(movement, Space.World);

    }
}