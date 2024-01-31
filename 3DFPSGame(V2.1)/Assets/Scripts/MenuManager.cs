using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject quitPanel;
    public void NewGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Chapters()
    {

    }
    public void Settings()
    {

    }
    public void Quit()
    {
        if (quitPanel.activeSelf)
        {
            Application.Quit();
            Debug.Log("çýktý");
        }
        else
        {
            quitPanel.SetActive(true);
        }
    }
    public void QuitPanelSwitch()
    {
        quitPanel.SetActive(!quitPanel.activeSelf);
    }
}
