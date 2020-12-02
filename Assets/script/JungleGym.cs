using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JungleGym : MonoBehaviour
{
    public Vector3 rotetoSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotetoSpeed);
    }
}
