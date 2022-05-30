using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float dirc;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dirc * Time.deltaTime, 0, 0);
    }
}
