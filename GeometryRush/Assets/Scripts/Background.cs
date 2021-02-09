using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Camera cam;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cam.transform.position;
    }
}
