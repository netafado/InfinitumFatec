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


    [SerializeField]
    private GameObject nave;
    [SerializeField]
    private float speed;

    private Vector3 offset;
	void Start () {
        offset = new Vector3(0, 0, 0);
        offset = transform.position - nave.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        seguirNave();
        olharDirecoNave();

	}
    void seguirNave() {
        transform.position = Vector3.Lerp(transform.position, nave.transform.position + offset, speed * Time.deltaTime);
       
    }

    void olharDirecoNave(){
        Vector3 posRelativa = nave.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(posRelativa, nave.transform.up);
    }
}
