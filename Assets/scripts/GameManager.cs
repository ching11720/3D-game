using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endText;
    int score;

    void Start () {
        score = 0;
        scoreText.text = "Score : " + score;
        endText.gameObject.SetActive(false);
    }
   
    public void addScore(int n){
        score += n;
        scoreText.text = "Score : " + score;
    }

    public void EndGame(){
        Time.timeScale = 0;
        endText.text = "Game Over\n" + "Your Score : " + score;
        endText.gameObject.SetActive(true);
    }

    void Update () {
        if ( score == 700 ){
            this.EndGame();
            endText.text = "Game Clear\n" + "Your Score : " + score;
            endText.gameObject.SetActive(true);
        }
    }
}
