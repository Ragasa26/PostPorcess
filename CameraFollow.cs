using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objek yang akan diikuti kamera (karakter)
    public Vector3 offset; // Offset posisi kamera dari karakter
    public float smoothSpeed = 0.125f; // Kecepatan smoothing untuk transisi kamera

    private void LateUpdate()
    {
        if (target == null) return; // Memastikan target diatur

        // Menentukan posisi target dengan offset
        Vector3 desiredPosition = target.position + offset;

        // Smooth damp untuk transisi yang mulus
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Menetapkan posisi kamera
        transform.position = smoothedPosition;

        // Mengarahkan kamera ke karakter
        transform.LookAt(target);
    }
}
