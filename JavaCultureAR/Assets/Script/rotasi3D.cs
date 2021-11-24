using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasi3D : MonoBehaviour
{
    public bool a = false;
    public Vector3 b;
    // Update is called once per frame
    void Update()
    {
        if (a)
        {
            transform.Rotate
            (
              b.x * Time.deltaTime * 10,
              b.y * Time.deltaTime * 10,
              b.z * Time.deltaTime * 10
            );
        }
    }
}
