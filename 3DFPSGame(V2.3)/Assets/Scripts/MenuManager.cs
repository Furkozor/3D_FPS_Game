using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Slider sensSlider;
    [SerializeField] private GameObject quitPanel, settingsPanel;
    public void NewGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Chapters()
    {

    }
    public void Settings()
    {
        if (settingsPanel.activeSelf) {
            settingsPanel.SetActive(false);
        }
        else
        {
            settingsPanel.SetActive(!settingsPanel.activeSelf);
        }

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

    private void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("sensValue"));
        if (!PlayerPrefs.HasKey("sensValue"))
        {
            PlayerPrefs.SetFloat("sensValue", 1);
        }
        sensSlider.value = PlayerPrefs.GetFloat("sensValue",1);
    }

    public void SensSlider()
    {
        PlayerPrefs.SetFloat("sensValue", (sensSlider.value));
        Debug.Log(PlayerPrefs.GetFloat("sensValue"));
    }
}
