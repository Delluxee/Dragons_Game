using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Enemigo : MonoBehaviour
{
    public int VidaEnemigo;

    void checkLife()
    {
        if( VidaEnemigo <= 0)
        {
            Debug.Log("Enemigo muerto");
        }
    }
}
