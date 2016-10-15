using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float minSpped;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        naveRotacao();
        paraFrente();  


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
        return speed;
    }
}
