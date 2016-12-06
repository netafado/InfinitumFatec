using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerLand : MonoBehaviour {

	private  UILand scriptGUI;
    private Audios scriptAudio;
   
    private int combustiveis = 0;
    private int maxCombustiveis = 4;

	void Start () {

        scriptGUI = GameObject.Find("UI").GetComponent<UILand>();
        scriptAudio = GameObject.Find("Audio").GetComponent<Audios>();
        Debug.Log("te");
    }
	
	// Update is called once per frame
	void Update () {
	    // se colidiu com a nave o jogo acabara ou ele sera avisado para pegar mais itens
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "nave")
        {
            if (combustiveis >= maxCombustiveis)
            {
                SceneManager.LoadScene("gameOver");
                return;
            }
                scriptGUI.turnOnMensagem();
           
        }
        else if (other.gameObject.tag == "rock")
        {
            Destroy(other.gameObject);
            combustiveis++;
           
        }else if(other.gameObject.name == "Porta")
        {
            Debug.Log("Porta");
            scriptAudio.playCapiroto();
        }
       
       
    }


}
