using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Fly : MonoBehaviour
{
    public GameObject objectToFind;
    string tagName = "Dragon";
    string tagName2 = "Dragon2";
    string tagName3 = "Dragon3";

    [SerializeField] private float Velocidad_Movimiento;
    [SerializeField] private Transform[] Puntos_Movimiento;
    [SerializeField] private float Distancia_Minima;
    private int Numero_Random;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Numero_Random = Random.Range(0, Puntos_Movimiento.Length);
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Puntos_Movimiento[Numero_Random].position, Velocidad_Movimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, Puntos_Movimiento[Numero_Random].position) < Distancia_Minima)
        {
            Numero_Random = Random.Range(0, Puntos_Movimiento.Length);
            Girar();

            Quaternion.Euler(0, 0, 180);
        }
    }
    private void Girar()
    {
        if (transform.position.x < Puntos_Movimiento[Numero_Random].position.x)
        {
            SpriteRenderer.flipX = true;
        }
        else
        {
            SpriteRenderer.flipX = false;
        }
    }
}
