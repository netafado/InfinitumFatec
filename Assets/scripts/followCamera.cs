using UnityEngine;
using System.Collections;
/**
 * Infinitum project
 * Script resposável por controlar a camera
 * o objeto com esse script adicionado irá seguir
 * o gameObject nave e sempre olhará para a direção 
 * desse objeto, a aproximãção sera feita de maneira 
 * suave 
 */
public class followCamera : MonoBehaviour {



    public Vector3 velocity = Vector3.one;
    public Vector3 distancia = Vector3.one;

    public float objDistance;

    public float velScalar;

    private GameState gameStateScript;

    [SerializeField]
    Transform target;

    Transform t;

    void Start()
    {
        t = transform;
        gameStateScript = GameObject.Find("GameStateObject").GetComponent<GameState>();
    }


    // Update is called once per frame
    void LateUpdate () {

        if(gameStateScript.CURRENT_STATE == GameState.GAME_STATE.jogando)
        {
            Vector3 toPos = target.position + (target.rotation.eulerAngles * velScalar);
            Vector3 curPos = Vector3.SmoothDamp(t.position, toPos, ref velocity, objDistance);
            t.position = curPos;
            t.LookAt(target, target.up);

        }else  
        {
            t.Translate(t.forward * 0.5f * Time.deltaTime);
            t.Rotate(new Vector3(0f, 0.01f, 0f));
            Debug.Log("intro");
        }       
       

	}
  
}
