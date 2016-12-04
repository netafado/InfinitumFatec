using UnityEngine;
using System.Collections;

public class PlanetaAlvo : MonoBehaviour {

    // Use this for initialization
    private Behaviour halo;

    [SerializeField]private float speed;
    [SerializeField]
    private float rotSpeed;

    void Start () {

        halo = (Behaviour)GetComponent("Halo");
        Debug.Log("conectado?:");    
       
	}
	
	// Update is called once per frame
	void Update () {
        //halo.GetType().GetProperty("Size").SetValue(halo, Mathf.Sin(Time.timeSinceLevelLoad / speed), null);

        transform.Rotate(0f, rotSpeed, 0f);
	}
}
