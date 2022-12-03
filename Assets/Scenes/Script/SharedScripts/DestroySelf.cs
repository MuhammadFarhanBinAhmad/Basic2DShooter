using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{

    public float time;

    // Start is called before the first frame update
    void Start()
    {
        /*OBJECTIVE:Invoke DestroyGameObject function
        *Invoke() is like ones own update function.
        *You can set a timer for the function to start
        *And set a time interval to call said function. eg. calling DestroyGameObject() every 2 seconds
        */
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
