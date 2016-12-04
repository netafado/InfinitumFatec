using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// Controle do menu principal
public class MainMenu : MonoBehaviour {

	// Use this for initialization

    public void goToMainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void goToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void btnJogar()
    {
        goToScene( "space" );
    }
    
}
