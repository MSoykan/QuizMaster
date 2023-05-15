using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndGame endgame;


    private void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endgame = FindObjectOfType<EndGame>();

    }

    void Start()
    {
        quiz.gameObject.SetActive(true);
        endgame.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endgame.gameObject.SetActive(true);
            endgame.ShowFinalScore();
        }
    }

    public void onReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
