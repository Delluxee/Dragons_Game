using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Limite : MonoBehaviour
{
    public GameObject[] Health;
    public int life;
    public GameObject[] Dragon;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Limite")
        {
            life--;
            Destroy(collision.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        if (tag == "Globo")
        {
            life--;
            Destroy(Health[1]);
        }
    }

    private void Update()
    {
        if (life < 1)
        {
            Destroy(Health[0].gameObject);
            SceneManager.LoadScene("GameOver");
        }
        else if (life < 2)
        {
            Destroy(Health[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(Health[2].gameObject);
        }
    }
}
