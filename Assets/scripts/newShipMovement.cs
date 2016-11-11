using UnityEngine;
using System.Collections;

public class newShipMovement : MonoBehaviour {

    
    [SerializeField]
    private float movementSpeed = 20;
    private float maxSpeed = 100;
    private float giroVelocidade = 30;
    Transform tr;


    // Use this for initialization
    void Start () {
        tr = transform;
	}
	
	// Update is called once per frame
	void Update () {

        paraFrente();
        girar();
	}

    void paraFrente()
    {
        tr.position += tr.forward * movementSpeed * Time.deltaTime;
    }

    void girar()
    {
        // Não sei o motivo, mas a rotação nos eixos x, y e z não segue a mesma orientação que esta no programa

        float upDown = giroVelocidade * Time.deltaTime * Input.GetAxis("Horizontal");
        float leftRight = giroVelocidade * Time.deltaTime * Input.GetAxis("Vertical");
        float eixo = giroVelocidade * Time.deltaTime * Input.GetAxis("Vertical");
        tr.Rotate(leftRight, upDown, eixo);
    }
}
