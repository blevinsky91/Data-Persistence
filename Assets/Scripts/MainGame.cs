using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = "Player: " + playerName;
    }
}