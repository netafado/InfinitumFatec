using UnityEngine;
using System.Collections;

public class Asteroids : MonoBehaviour {
    // scale de forma randomica o asteroid;

    private float scaleX;
    private float scaleY;
    private float scaleZ;

    private Vector3 rotationVel;

    [SerializeField]
    private GameObject explosao;

    [SerializeField]
    private float minRange;
    [SerializeField]
    private float maxRange;

    [SerializeField]
    private float RotateMin;
    [SerializeField]
    private float rotateMax;

    
   

    private Transform tr;
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

        tr = transform;

        // audio
      
    }
	
	// Update is called once per frame
	void Update () {
        tr.Rotate(rotationVel * Time.deltaTime);
	}
    // destruir o objeto
   public void colidiu(Vector3 position)
    {
        Instantiate(explosao, position, Quaternion.identity);
        
        DestroyObject(gameObject);        
    }



}
