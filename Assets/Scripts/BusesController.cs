using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusesController : MonoBehaviour
{
    public float busSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * busSpeed * Time.deltaTime);
    }
}
