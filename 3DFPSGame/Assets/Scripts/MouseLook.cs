using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens;

    public Transform body;

    float xRot = 0f;

    void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime; // X Rotasyonu olu�turup bu X
                                                                          // rotasyonunu Mouse'un X
                                                                          // rotasyonundan al�yoruz

        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime; // Y Rotasyonu olu�turup bu Y
                                                                          // rotasyonunu Mouse'un Y
                                                                          // rotasyonundan al�yoruz

        // --- KAMERAYI YUKARI A�A�I D�ND�RME --- \\
        xRot -= rotY; // Kameray� Y ekseninde ayarlamak i�in rotasyonu ayarl�yoruz.
        xRot = Mathf.Clamp(xRot, -90f, 90f); // Kameran�n Y rotasyonunu s�n�rland�r�yoruz ki 360
                                             // derece d�nmesin
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f); // Y rotasyonunu xRot kadar d�nd�r�yoruz

        // --- KAMERAYI SA�A SOLA D�ND�RME --- \\
        body.Rotate(Vector3.up * rotX);
    }
}
