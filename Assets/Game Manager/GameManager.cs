using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        GameReady, // ������ �⺻ ��
        GamePlay, // ���� ��
        GameSuccess, // ���� ����
        GameOver // ���� ����
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
            // Network�� ���� ������ ���ε� ��
        }
        else if (state == GameState.GameOver)
        {
            // Retryȭ���� ������
        }

    }
}
