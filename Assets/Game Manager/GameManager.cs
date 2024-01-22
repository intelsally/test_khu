using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        GameReady, // 시작전 기본 값
        GamePlay, // 게임 중
        GameSuccess, // 게임 성공
        GameOver // 게임 오버
    }
    public static GameManager Instance;
    public GameState state = GameState.GameReady;
    public float score = 5f;
    private void Awake()
    {
        Instance = this;
    }
   
    // Update is called once per frame
    void Update()
    {
        if (state == GameState.GamePlay)
        {
            score -= Time.deltaTime;
            if (score > 20)
            {
                state = GameState.GameSuccess;

            }
            else if (score < 0)
            {
                state = GameState.GameSuccess;
            }

        }
        else if (state == GameState.GameSuccess)
        {
            // Network를 통해 점수를 업로드 함
        }
        else if (state == GameState.GameOver)
        {
            // Retry화면을 보여줌
        }

    }
}
