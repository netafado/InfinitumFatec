using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Light))]
public class Combustivel : MonoBehaviour {

    [SerializeField]
    private float vel = 0.001f;

    private float angle = 1f;

    [SerializeField]
    private float maxInt = 3f;
    private float minInt = 1f;

    [SerializeField]
    private Vector3 rotateVextor;

    Light rockLight;

    private float toRadians = Mathf.PI / 180;

    [SerializeField]
    AudioClip pickup;

    AudioSource audioRock;


    void Start () {
        rockLight = GetComponent<Light>();
        audioRock = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        // light mudara a intensidade de acordo com uma determinada velocidade
        rockLight.intensity = Mathf.Cos(angle / toRadians) * maxInt + maxInt;

        //Debug.Log(rockLight.intensity);
        angle += vel * Time.deltaTime;

        transform.Rotate( rotateVextor );
        
	}

    public void playMusic()
    {
        audioRock.PlayOneShot(pickup);
    }
}
