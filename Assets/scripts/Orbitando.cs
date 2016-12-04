using UnityEngine;
using System.Collections;

public class Orbitando : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
    private float rotationSpeed = 10f;

    // controlar a camera para baixo e para cima
    [SerializeField] private float periodo = 2f;
    [SerializeField] private float amplitude = 2f;

    private float posY;
    private float distancia;

    void Start () {
        posY = transform.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {

        // posição em Y faz a camera ir para baixo e para cima
        distancia = Mathf.Sin(Time.timeSinceLevelLoad / periodo) * amplitude;
        transform.position = new Vector3(transform.localPosition.x, posY + distancia, transform.localPosition.z);

        //posição orbitando o objeto passado como target
        transform.RotateAround(target.position, Vector3.up, rotationSpeed * Time.deltaTime);

        // olha para o objecto target
        transform.LookAt(target);
	}
}
