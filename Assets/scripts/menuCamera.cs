using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuCamera : MonoBehaviour {

    private float limitX = 10000;
    private float limitZ = 10000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //move a camera
        transform.Translate(0.001f, 0, 0.001f);
        transform.Rotate(0, 0.01f, 0, Space.World);


	}
}
