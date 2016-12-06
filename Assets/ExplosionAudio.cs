using UnityEngine;
using System.Collections;

public class ExplosionAudio : MonoBehaviour {

    [SerializeField]
    private AudioClip shoot;
    private AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(shoot);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
