using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NextScene : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public Button startButton;
    public void GoToNextScene()
    {
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        string playerName = nameInputField.text;

        if (GameData.Instance != null)
        {
            GameData.Instance.playerName = playerName;
        }
    }
}
