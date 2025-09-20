using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Vector3 rotationVector;

    // Start is called before the first frame update
    private void Update()
    {
        transform.Rotate(rotationVector * Time.deltaTime);     
    }
}
