using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // config parameters
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    [SerializeField] float screenWidthInUnits = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Screen.width gives the width of the screen.
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        // Vector2 is a way to store x, y coordinates.
        Vector2 paddlePos = new Vector2(Mathf.Clamp(mousePosInUnits, minX, maxX), transform.position.y);
        // transform is a component of the Paddle object, where position is
        // an attribute under this component.
        transform.position = paddlePos;
    }
}

