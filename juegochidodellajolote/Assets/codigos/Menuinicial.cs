using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuinicial : MonoBehaviour
{
    public void Jugar(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);    
    }
    public void jugarch()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);    
    } 
    
}
