using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
        

        // controlar a rotacao da nave de acordo com as telas w, s, d, a sendo a e d
        // rotação em X e as demais teclas no Z
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f,Input.GetAxis("Horizontal"));

        transform.Translate(40*  Vector3.forward * Time.deltaTime);
         


    }
}
