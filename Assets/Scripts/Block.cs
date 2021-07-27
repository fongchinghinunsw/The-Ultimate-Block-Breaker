using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    // cached reference
    Level level;

    private void Start()
    {
        // get the Level object so that our block can call its public method.
        level = FindObjectOfType<Level>();
        level.countBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // destroy the object itself after 0s
        Destroy(gameObject, 0f);
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
    }
}
