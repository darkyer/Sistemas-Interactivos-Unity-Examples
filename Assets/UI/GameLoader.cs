using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public void LoadScene(int sceneNumber) // función pública de nombre "LoadScene"
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNumber); // carga una escena con el nombre que se le mande
    }
}
