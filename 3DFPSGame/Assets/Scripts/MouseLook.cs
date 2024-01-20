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
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime; // X Rotasyonu oluþturup bu X
                                                                          // rotasyonunu Mouse'un X
                                                                          // rotasyonundan alýyoruz

        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime; // Y Rotasyonu oluþturup bu Y
                                                                          // rotasyonunu Mouse'un Y
                                                                          // rotasyonundan alýyoruz

        // --- KAMERAYI YUKARI AÞAÐI DÖNDÜRME --- \\
        xRot -= rotY; // Kamerayý Y ekseninde ayarlamak için rotasyonu ayarlýyoruz.
        xRot = Mathf.Clamp(xRot, -90f, 90f); // Kameranýn Y rotasyonunu sýnýrlandýrýyoruz ki 360
                                             // derece dönmesin
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f); // Y rotasyonunu xRot kadar döndürüyoruz

        // --- KAMERAYI SAÐA SOLA DÖNDÜRME --- \\
        body.Rotate(Vector3.up * rotX);
    }
}
