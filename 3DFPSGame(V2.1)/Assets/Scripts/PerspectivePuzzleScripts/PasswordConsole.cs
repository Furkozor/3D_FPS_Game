using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PasswordConsole : MonoBehaviour
{
    [Header("The true combination (0031 in default)")]
    [SerializeField] private string TheTrueCombination = "0031";

    [Header("UI")]
    public GameObject PasswordMenu;
    private bool ConsoleInRange = false;
    public TextMeshProUGUI PasswordText;

    private void Start()
    {
        // Setting the default values
        PasswordMenu.SetActive(false);
        ConsoleInRange = false;
        Time.timeScale = 1;
        PasswordText.text = "";
    }

    private void Update()
    {
        if(ConsoleInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!PasswordMenu.activeSelf) // Open the console
            {
                PasswordMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else // Close the console
            {
                PasswordMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }


    #region Collision functions to enable the console UI
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ConsoleInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ConsoleInRange = false;
        }
    }

    #endregion

    #region Functions for buttons

    public void ExitFromTheMenu() // Close the menu
    {
        PasswordMenu.SetActive(false);
        Time.timeScale = 1;
    }

    #region Number buttons
    public void Number1()
    {
        if(PasswordText.text.Length < 4)
        {
            PasswordText.text += "1";
        }
        else if(PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number2()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "2";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number3()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "3";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number4()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "4";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number5()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "5";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number6()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "6";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number7()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "7";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number8()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "8";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }

    public void Number9()
    {
        if (PasswordText.text.Length < 4)
        {
            PasswordText.text += "9";
        }
        else if (PasswordText.text.Length == 4)
        {
            PasswordText.text = "";
        }
    }
    #endregion

    #endregion

}
