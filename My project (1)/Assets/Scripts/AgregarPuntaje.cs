using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarPuntaje : MonoBehaviour
{
    public int Puntaje = 20;
    public int vida_Enemigo;

    private void OnMouseDown()
    {
        if(tag == "Limite")
        {
            vida_Enemigo--;
            if(vida_Enemigo <= 0)
            {
                Destroy(gameObject,2f);
                GameControler.Score += Puntaje;
            }
        }       
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
