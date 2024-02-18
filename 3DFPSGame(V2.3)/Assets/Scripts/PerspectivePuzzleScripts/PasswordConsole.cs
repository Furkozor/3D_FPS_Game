using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasswordConsole : MonoBehaviour
{
    [Header("The true combination (0031 in default)")]
    [SerializeField] private string TheTrueCombination = "0031";
    private bool TrueCombinationHasBeenEntered = false;

    [Header("UI")]
    public GameObject PasswordMenu;
    private bool ConsoleInRange = false;
    public TextMeshProUGUI PasswordText;
    public Image PasswordTextBackground;

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

        if(PasswordText.text == "0031") // If the player gives the correct answer
        {
            TrueCombinationHasBeenEntered = true;
            PasswordTextBackground.color = Color.green;
            Debug.Log("You solved the puzzle");
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

    public void Number0()
    {
        if (!TrueCombinationHasBeenEntered)
        {
            if (PasswordText.text.Length < 4)
            {
                PasswordText.text += "0";
            }
            else if (PasswordText.text.Length == 4)
            {
                PasswordText.text = "";
            }
        }
    }

    public void Number1()
    {
        if (!TrueCombinationHasBeenEntered)
        {
            if (PasswordText.text.Length < 4)
            {
                PasswordText.text += "1";
            }
            else if (PasswordText.text.Length == 4)
            {
                PasswordText.text = "";
            }
        }       
    }

    public void Number2()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number3()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number4()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number5()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number6()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number7()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number8()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    public void Number9()
    {
        if (!TrueCombinationHasBeenEntered)
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
    }

    #endregion

    #endregion

}
