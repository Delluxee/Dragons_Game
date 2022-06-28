using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Humano : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("GameOver");
    }
}
