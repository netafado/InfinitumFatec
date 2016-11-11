using UnityEngine;
using System.Collections;

public class Asteroids : MonoBehaviour {
    // scale de forma randomica o asteroid;

    private float scaleX;
    private float scaleY;
    private float scaleZ;

    private Vector3 rotationVel;

    [SerializeField]
    private float minRange;
    [SerializeField]
    private float maxRange;

    [SerializeField]
    private float RotateMin;
    [SerializeField]
    private float rotateMax;


    // rotaçao de forma randomica tambem

    // velocidade


    // Use this for initialization
    void Start () {
        scaleX = Random.Range(minRange, maxRange);
        scaleY = Random.Range(minRange, maxRange);
        scaleZ = Random.Range(minRange, maxRange);

        rotationVel = new Vector3(
                    Random.Range(RotateMin, rotateMax),
                    Random.Range(RotateMin, rotateMax),
                    Random.Range(RotateMin, rotateMax)
                    );

        transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        transform.Rotate(rotationVel);


    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotationVel * Time.deltaTime);
	}
}
