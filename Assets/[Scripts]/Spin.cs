using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinInPlace : MonoBehaviour
{
    
    public float spinSpeed = 10f;

    public Vector3 rotationAxis = new Vector3(0, 0, 0); // Default to Y-axis (like a coin)

    void Update()
    {
        // Vector3.Normalize ensures smooth speed even if you combine multiple axes
        Vector3 direction = rotationAxis.normalized;

        // Rotates the object in place every frame smoothly
        transform.Rotate(direction * spinSpeed * Time.deltaTime, Space.Self);
    }
}