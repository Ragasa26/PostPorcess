using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Sensitivitas mouse
    public Transform playerBody; // Objek karakter yang akan diikuti kamera

    private float xRotation = 0f; // Mengatur rotasi vertikal

    private void Start()
    {
        // Mengunci kursor di tengah layar dan menyembunyikannya
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Mendapatkan input mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Mengatur rotasi vertikal (pitch) berdasarkan gerakan mouse Y
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Membatasi sudut vertikal agar tidak berputar 360 derajat

        // Mengubah rotasi kamera pada sumbu X
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Mengatur rotasi horizontal (yaw) pada playerBody berdasarkan gerakan mouse X
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
