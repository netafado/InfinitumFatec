using UnityEngine;
using System.Collections;

public class SeguirACamera : MonoBehaviour {

    [SerializeField]private float amplitude = 30f;
    [SerializeField]private float periodo = 2f;

    private Vector3 localPosition;
	void Start () {
        localPosition = transform.localPosition;

    }
	
	// Update is called once per frame
	void Update () {
        float dt = (Mathf.Sin(Time.timeSinceLevelLoad / periodo) * amplitude);
        Vector3 distan = new Vector3(0, 0, dt);
        transform.position = localPosition + distan;

    }
}
