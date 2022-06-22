using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido_Muerte_Enemigos : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip AudioFX;

    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(AudioFX, gameObject.transform.position);
        Destroy(gameObject, 0.1f);
    }


}
