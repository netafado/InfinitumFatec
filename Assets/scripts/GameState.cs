using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {
    
    // para controlar o stato atual do jogo
    public enum GAME_STATE{
        pause, intro, jogando
    }


    public GAME_STATE CURRENT_STATE = GAME_STATE.intro;

    // Variaveis necessarias para controlar o jogo
    [SerializeField] GameObject nave;
    private Nave naveScript;
    private Text textGameState;
    private followCamera mainCameraScript;
    private GameObject scrollIntro;
    private GameObject btnSkyp;
    //[SerializeField] followCamera scritCamera;

    //textos para mostrar no monitor
    [SerializeField] private string tPausado;
    [SerializeField] private string tJogando;
    [SerializeField] private string tIntro;



    void Start () {
       
        naveScript = nave.GetComponent<Nave>();
        textGameState = GameObject.Find("TextosGameStates").GetComponent<Text>();
        mainCameraScript = GameObject.Find("Main Camera").GetComponent<followCamera>();
        scrollIntro = GameObject.Find("ScrollIntro");
        btnSkyp = GameObject.Find("ButtonSkip");

    }
	
	void Update () {

	    if(CURRENT_STATE == GAME_STATE.pause)
        {
            naveScript.enabled = false;
            textGameState.text = tPausado;
            mainCameraScript.enabled = false;
            scrollIntro.SetActive(false);
            btnSkyp.SetActive(false);
        }
        else if( CURRENT_STATE == GAME_STATE.jogando)
        {
            naveScript.enabled = true;
            textGameState.text = tJogando;
            mainCameraScript.enabled = true;
            scrollIntro.SetActive(false);
            btnSkyp.SetActive(false);

        }
        else if(CURRENT_STATE == GAME_STATE.intro)
        {
            naveScript.enabled = false;
            textGameState.text = tIntro;
            mainCameraScript.enabled = true;
            scrollIntro.transform.Translate(new Vector3(0f, 0f, 0f));
            scrollIntro.SetActive(true);
            btnSkyp.SetActive(true);
        }



        // começar o jogo
        if (CURRENT_STATE != GAME_STATE.jogando  && Input.GetButton("Submit"))
            CURRENT_STATE = GAME_STATE.jogando;
	}
    
    void resetGame()
    {
        SceneManager.LoadScene("land");
    }

    public void setState(GAME_STATE state)
    {
        CURRENT_STATE = state;
    }




}
