using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARObjectRotator : MonoBehaviour
{
    private float rotationSpeed = 0.5f;
    private Vector2 lastPos;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 deltaPos = Input.GetTouch(0).deltaPosition;
            float rotation = deltaPos.x * rotationSpeed;
            transform.Rotate(0, -rotation, 0);
        }
    }
}