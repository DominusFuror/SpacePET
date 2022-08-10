using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    static ScoreCounter scoreCounter;

    static public ScoreCounter GetScoreCounter()
    {


        return scoreCounter;
    }
    
    public ScoreCounter()
    {
        scoreCounter = this;

    }


    public void AddScore(int addedScore)
    {

        score += addedScore;
    }
    [SerializeField]
    Text scoreText;
    int score = 0;
    int textScore = 0;

    IEnumerator ScoreTextChanger()
    {
        while (true)
        {
           
            if (textScore < score)
            {
                textScore++;
                scoreText.text = "Score : " +textScore.ToString();
            }
            yield return new WaitForEndOfFrame();

        }
        

    }
    private void Start()
    {
        StartCoroutine(ScoreTextChanger());
    }
}
