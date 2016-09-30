using UnityEngine;
using System.Collections;

public class followCamera : MonoBehaviour {


    [SerializeField]
    private GameObject nave;

    private float offsetZ = 10.2f;
    private float offsetY = -4.0f;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = new Vector3(0.0f, offsetY, offsetZ);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = nave.transform.position - offset;
	}
}
