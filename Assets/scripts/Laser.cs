using UnityEngine;
using System.Collections;
[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(Light))]
public class Laser : MonoBehaviour {

    LineRenderer lr;

    Light lightTiro;

    [SerializeField]
    float laserOffTime = .5f;

    [SerializeField]
    float maxDist = 300f;

    GameState gameState;

    bool canFIre = false;

	void Start () {
        lr = GetComponent<LineRenderer>();
        lr.enabled = false;

        lightTiro = GetComponent<Light>();
        lightTiro.intensity = 0f;

        gameState = GameObject.Find("GameStateObject").GetComponent<GameState>();

	}


    Vector3 CasRay()
    {
        RaycastHit hit;

        Vector3 v = -transform.TransformDirection(Vector3.forward) * maxDist;

        if(Physics.Raycast(transform.position, v, out hit))
        {
            
            if(hit.transform.gameObject.tag == "asteroid") 
            {
                Asteroids script = hit.transform.GetComponent<Asteroids>();
               
                    script.colidiu(hit.point);
                
                    
            }
            return hit.point;
        }
        return -transform.TransformDirection(Vector3.forward) * maxDist;

    }

    public void FireLaser()
    {
        if (canFIre && gameState.CURRENT_STATE == GameState.GAME_STATE.jogando && Input.GetButton("Fire1"))
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, transform.position + CasRay());
            lr.enabled = true;
            canFIre = false;
            lightTiro.intensity = 2f;

        }

        Invoke("TurnOffLaser", laserOffTime);

    }

    public void TurnOffLaser()
    {
        lr.enabled = false;
        canFIre = true;
        lightTiro.intensity = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        FireLaser();
        Debug.DrawRay(transform.position, -transform.TransformDirection(Vector3.forward) * maxDist, Color.yellow);
	}
}
