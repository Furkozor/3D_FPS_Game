using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false; // Ýmleci görünmez yapýyoruz
        Cursor.lockState = CursorLockMode.Locked; // Ýmleci ekranýn ortasýna kilitliyoruz.
    }
}
