using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Sprite[] PlayerLife;
    public Image liveImageDisplay;  //ui image add 
    public Text ScoreText;
    public int score;
    public GameObject MainImgPrefab;
   public void UpdateLives(int CurrentLive)
    {
       // Debug.Log("player lives= " + CurrentLive);
      liveImageDisplay.sprite = PlayerLife[CurrentLive];
    }

    public void UpdateScore()
    {
        score += 10;
        ScoreText.text = "Score : " + score;
    }
}
