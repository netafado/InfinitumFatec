using UnityEngine;
using System.Collections;

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "prop_powerCube")
        {
            Destroy(col.gameObject);
        }
    }
}
