using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Click : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

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
