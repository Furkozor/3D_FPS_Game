using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DayAndNightConsole : MonoBehaviour
{
    [Header("Sun of the Scene")]
    public Light DirectionalLight;
    [SerializeField] [Range(1,12)] private int Clock;

    void Update()
    {

        switch (Clock) // Change the directional light rotation according to the clock
        {
            case 1:
            DirectionalLight.transform.rotation = Quaternion.Euler(15*Clock, -30 , 0);
                break;

            case 2:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 3:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 4:
                DirectionalLight.transform.rotation = Quaternion.Euler(69 , -30, 0);
                break;

            case 5:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 6:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 7:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 8:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 9:
                DirectionalLight.transform.rotation = Quaternion.Euler(131, -30, 0);
                break;

            case 10:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 11:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 12:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;
        }
       
    }
}
