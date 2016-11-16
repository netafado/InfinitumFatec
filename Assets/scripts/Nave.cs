using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Nave : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float minSpped;

    // mudar o angulo da camera
    followCamera mainCamera;
    private float maxTimerCamera = 2f;
    private float cameraTimer = 0f;
    private bool colidiuComPlaneta = false;
    


	// Use this for initialization
	void Start () {
        mainCamera = GameObject.Find("Main Camera").GetComponent<followCamera>();        
	}
	
	// Update is called once per frame
	void Update () {

        naveRotacao();
        paraFrente(); 
        
        if(colidiuComPlaneta)
        {
            cameraTimer += Time.deltaTime;
            mainCamera.velScalar = 0.3f;

            if (cameraTimer > maxTimerCamera)
            {
                cameraTimer = 0f;
                irParaScene("land");
            }
        } 


    }

    private void paraFrente()
    {
        transform.Translate(speed * Vector3.forward * Time.deltaTime);       

        // acelera
        if(Input.GetButton("Jump")){
            acelera();
        }
        else
        {
            desacelera();
        }
    }

   private void acelera()
    {
        speed += 0.1f;
        if (speed > maxSpeed)
            speed = maxSpeed;

    }

    private void desacelera()
    {
        if(speed > minSpped)
        {
            speed -= 0.1f;
        }
    }

    void naveRotacao()
    {
        // controlar a rotacao da nave de acordo com as telas w, s, d, a sendo a e d
        // rotação em X e as demais teclas no Z
        float rotaX = Input.GetAxis("Vertical");
        float rotaZ = Input.GetAxis("Horizontal");

      
       transform.Rotate(rotaX, rotaZ, 0.0f);


    }

    public float getSpeed()
    {
        return this.speed;
    }
    

    // fazer alguma coisa quando colider com o asteroid
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "asteroid")
        {
            Debug.Log("asteroid colisão");
        }

        if (col.gameObject.name == "planeta-alvo")
        {
            colidiuComPlaneta = true;
        }

       
    }

    void irParaScene(string sceneName)
    {
        SceneManager.LoadScene("land");
    }
}
