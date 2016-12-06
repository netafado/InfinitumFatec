using UnityEngine;
using System.Collections;


public class Audios : MonoBehaviour {
    [SerializeField]
    AudioClip musicaAmbiente;

    [SerializeField]
    AudioClip musicaCapiroto;

    AudioSource audioS;

    bool isPlaying = false;
    float capirotoTempo = 33f;
    float timer = 0;

    void Start()
    {
        audioS = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;
            if( timer >= capirotoTempo)
            {
                isPlaying = false;
            }
        }
    }

    public void playAmbiente()
    {

    }

    public void playCapiroto()

    {
        if (!isPlaying)
        {
            audioS.PlayOneShot(musicaCapiroto);
            isPlaying = true;
        }
      
    }
}
