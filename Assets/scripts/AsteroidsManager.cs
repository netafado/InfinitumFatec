using UnityEngine;
using System.Collections;

public class AsteroidsManager : MonoBehaviour {

    [SerializeField]private GameObject asteroid;
    [SerializeField]private int quantAsteroids;
    [SerializeField]private float espacoEntreAsteroids;
    [SerializeField]private float randomPos;

    // Use this for initialization
    void Start () {
        quantosAsteroids();
	}

    void quantosAsteroids()
    {

       for(int i = 0; i < quantAsteroids; i++)
        {
            for (int k = 0; k < quantAsteroids; k++)
            {
                for (int j = 0; j < quantAsteroids; j++)
                {
                    criarAsteroid(i * espacoEntreAsteroids + randomNumber(), 
                                  k * espacoEntreAsteroids + randomNumber(), 
                                  j * espacoEntreAsteroids + randomNumber());
                }
            }
        }
    }

    public float randomNumber()
    {
        return Random.Range(-randomPos, randomPos);
    }

    public void criarAsteroid(float x, float y, float z)
    {
        Instantiate(asteroid, 
                    new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z), 
                    Quaternion.identity, 
                    transform);
    }


	
	// Update is called once per frame
	void Update () {
	
	}
}
