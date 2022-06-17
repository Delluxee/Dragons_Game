using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    private Transform TheTransform;
    public Vector2 Hrange = Vector2.zero;
    public Vector2 Vrange = Vector2.zero;

    private void LateUpdate()
    {
        TheTransform.position = new Vector3(
        Mathf.Clamp(transform.position.x, Vrange.x, Vrange.y),
        Mathf.Clamp(transform.position.y, Vrange.x, Vrange.y),
        transform.position.z);
    }

    private void Start()
    {
        TheTransform = GetComponent<Transform>();
    }

}
