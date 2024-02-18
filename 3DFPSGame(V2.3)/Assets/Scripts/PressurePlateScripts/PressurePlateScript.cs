using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateScript : MonoBehaviour
{
    [SerializeField] private Animator NextDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (openTrigger)
            {
                NextDoor.SetTrigger("open"); //Kapi acma animasyonu girer
                Debug.Log("opentrigger");
            }

            else if (closeTrigger)
            {
                NextDoor.SetTrigger("close"); //Kapi kapanma animasyonu girer
                Debug.Log("closetrigger");
            }
        }
    }

}
