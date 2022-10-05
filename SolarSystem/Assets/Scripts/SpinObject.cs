using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public Vector3 rotationAxis;
    public float spinSpeed = 10.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

        transform.Rotate(rotationAxis, spinSpeed * Time.deltaTime);
    }
}
