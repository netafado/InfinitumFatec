using UnityEngine;
using System.Collections;

// script para piramides flutuantes girarem.
public class FloatingThing : MonoBehaviour {

    private float random;

	// Use this for initialization
	void Start () {
        random = Random.Range(-2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0.0f, random * Time.deltaTime, 0.0f, Space.World);
	}
}
