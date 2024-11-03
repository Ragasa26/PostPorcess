using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Komponen Rigidbody karakter
    public float speed = 5f; // Kecepatan karakter
    private Vector3 moveDirection;

    private void Start()
    {
        // Mendapatkan Rigidbody dari karakter
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Membekukan rotasi Rigidbody agar tidak terpengaruh oleh fisika
    }

    private void Update()
    {
        // Mendapatkan input gerakan
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Menentukan arah gerakan berdasarkan arah karakter
        moveDirection = transform.right * moveX + transform.forward * moveZ;
    }

    private void FixedUpdate()
    {
        // Menggerakkan karakter menggunakan Rigidbody
        Vector3 moveVelocity = moveDirection * speed;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
