using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UILand : MonoBehaviour {

    private float timer;

    
    private Text texto;
    private GameObject painel; 

    [SerializeField]
    private float showUITime;
    [SerializeField]
    private bool mensagemNaTela;

	void Start () {
        texto = GameObject.Find("GUIText").GetComponent<Text>();
        painel = GameObject.Find("Panel");
	}
	

	void Update () {
	    // verefica se colidiu com a nave e mostra a mensagem caso não tenha o numero suficiente de combustivel

        if( mensagemNaTela )
        {
            Showintro();
        }

        // se tiver mostrando depois de um tempo ele desaperece.
	}

    void Showintro()
    {
        painel.SetActive(true);
        texto.enabled = true;

        timer += Time.deltaTime;
        if(timer > showUITime)
        {
            // mostra a mensagem
            // ativa os componentes
            mensagemNaTela = false;
            HideMenssage();
            timer = 0f;
        }
    }

    void HideMenssage()
    {
        painel.SetActive(false);
        texto.enabled = false;
    }

    public void turnOnMensagem()
    {
        mensagemNaTela = true;
    }

   

    
}
