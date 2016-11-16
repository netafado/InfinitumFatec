using UnityEngine;
using System.Collections;


public class btnIntro : MonoBehaviour {

    public GameState gameStateScript;

    void Start()
    {
        gameStateScript = GameObject.Find("GameStateObject").GetComponent<GameState>();
    }



    public void gameStateIntro() {
        gameStateScript.setState(GameState.GAME_STATE.intro);
    }
    public void gameStatePause() {
        gameStateScript.setState( GameState.GAME_STATE.pause);
    }
    public void gameStateJogando() {
        gameStateScript.setState(GameState.GAME_STATE.jogando);
    }
}
