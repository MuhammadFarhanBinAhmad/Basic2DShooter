using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float s_Movement;

    Rigidbody2D the_rb;
    [SerializeField]Camera the_Camera;

    Vector2 mousePos;

    private void Start()
    {
        the_rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
        mousePos = the_Camera.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector2 lookDirection = mousePos - the_rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        the_rb.rotation = angle;
    }
    void Movement()
    {
        //OBJECTIVE: Create player movement
        /*
         * One can assign the variable to function. Do have an idea on how to do it?
         * You need 2 float variable for vertical and horizontal movement
         * then use transform.position to move the player
         */
        /*float m_HorizontalMovement = Input.GetAxisRaw("Horizontal");
        float m_VerticalMovement = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(m_HorizontalMovement, m_VerticalMovement, 0) * s_Movement * Time.fixedDeltaTime;*/

    }
}
