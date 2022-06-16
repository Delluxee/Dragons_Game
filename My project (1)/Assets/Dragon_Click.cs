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
        gameObject.SetActive(false);       
    }
}
