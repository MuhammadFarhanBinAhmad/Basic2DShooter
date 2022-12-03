using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{

    public float time;

    // Start is called before the first frame update
    void Start()
    {
        //LEARNING POINT:Invoke Function and what it does
        //Invoke() is a function in which 
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
