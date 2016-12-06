using UnityEngine;
using System.Collections;

public class Capiroto : MonoBehaviour {

    [SerializeField]
    private GameObject target;
    private Rigidbody body;
    [SerializeField]
    private float force = 40f;


    // controle do ataque
    private float esperar = 10f;
    private float timer = 0f;

    private bool esperarAtaque = false;
	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(target.transform);

        Vector3 dist = transform.position - target.transform.position;
        float mag = dist.magnitude;

        if (mag < 6)
        {
            if (!esperarAtaque)
            {
                body.AddForce(transform.forward * force, ForceMode.Force);
                Debug.Log("force");
                esperarAtaque = true;

            }

            if (timer >= esperar)
            {
                timer = 0;
                esperarAtaque = false;
            }

        }

        timer += Time.deltaTime;
           
	}
}
