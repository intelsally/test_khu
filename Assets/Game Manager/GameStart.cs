using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    private Button _button;
    private void Awake()
    {
        //_button = GetCompoent<Button>();
    }
    public void OnGameStartButtonClick()
    {
        GameManager.Instance.state = GameManager.GameState.GamePlay; 
    }
    private void Update()
    {
        //if ( GameManager.Instance.state == )
    }
    
}