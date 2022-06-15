using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("limite");
        if (other.tag == "Dragon")
        {
            Destroy(gameObject);
        }
    }
}
