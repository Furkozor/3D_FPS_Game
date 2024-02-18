using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSweeperTexts : MonoBehaviour
{
        bool hasMoved = false;
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (!hasMoved)
            {
                transform.position += new Vector3(0,0.12f,0);
                hasMoved = true;
                Debug.Log("SpecialTexts");
            } 
        }
    }
}
