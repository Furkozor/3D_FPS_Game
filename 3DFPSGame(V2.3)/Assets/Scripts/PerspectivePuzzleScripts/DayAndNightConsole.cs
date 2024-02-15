using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DayAndNightConsole : MonoBehaviour
{
    [Header("Sun of the Scene")]
    public Light DirectionalLight;

    [Header("Clock System")]
    [SerializeField] [Range(1,23)] private int Clock;

    [Header("Clock UI")]
    public TextMeshProUGUI ClockText;
    public GameObject ClockMenu;
    private bool inTheRangeOfClock = false;

    private void Start()
    {
        // Setting the default values
        Clock = 1;
        ClockMenu.SetActive(false);
        inTheRangeOfClock = false;
        Time.timeScale = 1;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && inTheRangeOfClock)
        {
            if (!ClockMenu.activeSelf)
            {
                ClockMenu.SetActive(true);
                Time.timeScale = 0;
                // Also need to close the camera input
            }
            else
            {
                ClockMenu.SetActive(false);
                Time.timeScale = 1;
                // Also need to open the camera input
            }

        }

        if(Clock > 23) // Clock cannoot be higher than 23
        {
            Clock = 23;
        }
        if (Clock < 1) // Clock cannot be lower than 1
        {
            Clock = 1;
        }

        switch (Clock) 
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

            case 13:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 14:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 15:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 16:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 17:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 18:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 19:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 20:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 21:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 22:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 23:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;

            case 24:
                DirectionalLight.transform.rotation = Quaternion.Euler(15 * Clock, -30, 0);
                break;
        } // Change the directional light rotation according to the clock

        if (Clock < 10)
        {
            ClockText.text = "0" + Clock.ToString() + " : 09";
        }
        else if (Clock >= 10 && Clock < 24)
        {
            ClockText.text = Clock.ToString() + " : 09";
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTheRangeOfClock = true;
        }        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTheRangeOfClock = false;
        }       
    }

    #region Functions for buttons
    public void IncreaseTheClock()
    {
        Clock++;
    }

    public void DecreaseTheClock()
    {
        Clock--;
    }

    public void ExitFromTheMenu ()
    {
        ClockMenu.SetActive(false);
        Time.timeScale = 1;
    }

    #endregion 
}
