using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false; // �mleci g�r�nmez yap�yoruz
        Cursor.lockState = CursorLockMode.Locked; // �mleci ekran�n ortas�na kilitliyoruz.
    }
}
