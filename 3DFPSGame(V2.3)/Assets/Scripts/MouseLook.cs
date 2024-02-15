using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens; // Sensitivity ayar� i�in 50 ile 500 aras�nda zorunlu k�l�nm�� sens de�i�keni tan�mlad�k.

    public Transform body; // Karakterimizi d�nd�rmek i�in body tan�mlad�k

    float xRot = 0f; // Rotasyon i�in xRot de�i�keni tan�mlad�k;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        sens = PlayerPrefs.GetFloat("sensValue") * 50;

    }

    void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime; // X Rotasyonu olu�turup bu X rotasyonunu
                                                                          // Mouse'un X rotasyonundan ald�k.

        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime; // Y Rotasyonu olu�turup bu Y rotasyonunu
                                                                          // Mouse'un Y rotasyonundan ald�k.

        // --- KAMERAYI YUKARI A�A�I D�ND�RME --- \\
        xRot -= rotY; // Kameray� Y ekseninde ayarlamak i�in rotasyonu ayarlad�k.
        xRot = Mathf.Clamp(xRot, -90f, 90); // Kameran�n Y rotasyonunu -90(tam a�a��) ile 90(tam yukar�) olarak s�n�rland�rd�k ki 360 derece d�nmesin.
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f); // Y rotasyonunu xRot kadar d�nd�r.

        // --- KAMERAYI SA�A SOLA D�ND�RME --- \\
        body.Rotate(Vector3.up * rotX);
    }
}
