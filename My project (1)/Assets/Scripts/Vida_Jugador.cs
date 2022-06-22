using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Jugador : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    public GameObject[] enemy;

    private void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(tag == "Dragon")
        {
            life--;
            Destroy(collision.gameObject);
        }
    }
}
