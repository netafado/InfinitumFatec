using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CamerasManager : MonoBehaviour {

    
    [SerializeField]private List<GameObject> cameras;
    private int currentCamera = 0;
    private int indexCamera = 0;

    [SerializeField]private float timer = 0f;
    [SerializeField]private float timerTroca = 4f;

    [SerializeField]private Image fader;
    [SerializeField]private float speed;

    [SerializeField]private Color colorTo;

    void Start () {
        cameras[currentCamera].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        // troca a camera de tempos em tempos de acordo com o valor passado.
        if(timer > timerTroca)
        {
            indexCamera += 1;
            //Debug.Log("Camera index:" + indexCamera);
            

            // controla a variavel currentCamera para não ser maior que a lista cameras
            if (indexCamera > cameras.Count -1)
                indexCamera = 0;

            timer = 0f;
        }

        trocarCamera(indexCamera);
  
	}
      

    void trocarCamera(int indexCamera)
    {
        // fazer o fade In caso a camera seja trocada
        if (currentCamera != indexCamera)
        {
            
            if (fader.color.a <= 0.98f)
            {
                Debug.Log("Fader: "+ fader.color.a);
                fader.color = Color.Lerp(fader.color, colorTo, speed * Time.deltaTime);
            }
            else
            {
                //Debug.Log("troca camera");
                cameras[currentCamera].SetActive(false);
                currentCamera = indexCamera;
                cameras[currentCamera].SetActive(true);
            }

        }
        else 
        {
            // fazer o fade out para sempre mostrar a camera
            if (fader.color.a >= 0.03f )
            {
                fader.color = Color.Lerp(fader.color, Color.clear, speed * Time.deltaTime);
            }
            else
            {
                fader.color = Color.clear;
            }
            
        }    

    }
}
