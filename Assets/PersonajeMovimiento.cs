using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMovimiento : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer sp;
    private Rigidbody2D rb;
    private Collider2D col;
    public float speed = 5.0f;
    public float fuerzaSalto = 200.0f;
    public bool onGround = false;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onGround = isGrounded();
        //Debug.Log("En el suelo?: " + onGround);

        var horizontal = 0;
        var vertical = 0;

        // Movimiento a los lados.
        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = 1;
        }
        else if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = -1;
        }

        if (horizontal > 0)
        {
            sp.flipX = false;
        }
        else if (horizontal < 0)
        {
            sp.flipX = true;
        }

        // Si no se está movimiento dejamos el idle.
        if (rb.velocity.magnitude < 0.1)
            animator.SetBool("isIdle", true);
        else
            animator.SetBool("isIdle", false);


        // Control del salto.
        if ((Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded())
        {
            //horizontal = 1;
            Vector3 vSalto = new Vector3(0, 1, 0);
            rb.AddForce(vSalto * fuerzaSalto);
        }

        

        Vector3 move = new Vector3(horizontal, vertical, 0);
        rb.AddForce(move * speed);
    }

    private bool isGrounded() {
        float distToGround = col.bounds.extents.y;
        //Debug.Log("Distancia al suelo: " + distToGround);
        return Physics2D.Raycast(transform.position, -Vector2.up, distToGround + 0.5f);
        //var hit: RaycastHit2D = Physics2D.Raycast(transform.position, -Vector2.up, 0.1);
    }

    public void sobreHueso()
    {
        animator.SetBool("isEuforico", true);
    }

    public void abandonaHueso()
    {
        animator.SetBool("isEuforico", false);
    }

    public void sobreCaca()
    {
        animator.SetBool("isCaca", true);
    }

    public void abandonaCaca()
    {
        animator.SetBool("isCaca", false);
    }


}
