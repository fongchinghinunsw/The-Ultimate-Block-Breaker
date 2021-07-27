using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // for debugging purposes

    public void countBreakableBlocks()
    {
        breakableBlocks++;
    }
}
