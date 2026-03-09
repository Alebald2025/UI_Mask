using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBola8 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);  
    }

    void rotateAlrevez()
    {
        transform.Rotate(0, -50 * Time.deltaTime, 0);
    }
}
