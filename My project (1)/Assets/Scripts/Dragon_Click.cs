using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Click : MonoBehaviour
{
    public GameObject[] Heart;
    public int life;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Dragon")
        {
            Destroy(gameObject);
        }
    }
}
