using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Nivel");
    }
    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Reglas()
    {
        SceneManager.LoadScene("Reglas");
    }
}
