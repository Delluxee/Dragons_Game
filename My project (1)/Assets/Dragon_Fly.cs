using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Fly : MonoBehaviour
{
    [SerializeField] public float Velocidad_Movimiento;
    [SerializeField] public Transform[] Puntos_Movimiento;
    [SerializeField] public float Distancia_Minima;
    public int Numero_Random;
    public SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Numero_Random = Random.Range(0, Puntos_Movimiento.Length);
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Puntos_Movimiento[Numero_Random].position, Velocidad_Movimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, Puntos_Movimiento[Numero_Random].position) < Distancia_Minima)
        {
            Numero_Random = Random.Range(0, Puntos_Movimiento.Length);
        }
    }
}
