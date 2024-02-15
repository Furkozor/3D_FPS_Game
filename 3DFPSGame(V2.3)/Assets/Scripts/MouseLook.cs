using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens; // Sensitivity ayarý için 50 ile 500 arasýnda zorunlu kýlýnmýþ sens deðiþkeni tanýmladýk.

    public Transform body; // Karakterimizi döndürmek için body tanýmladýk

    float xRot = 0f; // Rotasyon için xRot deðiþkeni tanýmladýk;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        sens = PlayerPrefs.GetFloat("sensValue") * 50;

    }

    void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime; // X Rotasyonu oluþturup bu X rotasyonunu
                                                                          // Mouse'un X rotasyonundan aldýk.

        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime; // Y Rotasyonu oluþturup bu Y rotasyonunu
                                                                          // Mouse'un Y rotasyonundan aldýk.

        // --- KAMERAYI YUKARI AÞAÐI DÖNDÜRME --- \\
        xRot -= rotY; // Kamerayý Y ekseninde ayarlamak için rotasyonu ayarladýk.
        xRot = Mathf.Clamp(xRot, -90f, 90); // Kameranýn Y rotasyonunu -90(tam aþaðý) ile 90(tam yukarý) olarak sýnýrlandýrdýk ki 360 derece dönmesin.
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f); // Y rotasyonunu xRot kadar döndür.

        // --- KAMERAYI SAÐA SOLA DÖNDÜRME --- \\
        body.Rotate(Vector3.up * rotX);
    }
}
