using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Click : MonoBehaviour
{
    public GameObject[] Heart;
    public int VidaEnemigo;
    public Animator animacion;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Dragon")
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (VidaEnemigo <= 0)
        {
            animacion.SetBool("Explosion", true);
        }
    }
    public void MyOnDestroy()
    {
        Destroy(gameObject);
    }
}

