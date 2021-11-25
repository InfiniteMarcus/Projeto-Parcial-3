using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjeto : MonoBehaviour
{
    private bool moved;
    Animator m_Animator;
    public float force;

    private void Start()
    {
        moved = false;
        m_Animator = gameObject.GetComponentInChildren<Animator>();
    }

    void Update()
    {
       if(Input.GetKeyDown("z") && moved == false)
        {
            moved = true;

            if (!m_Animator.GetBool("Activate"))
            {
                m_Animator.SetBool("Activate", true);
            }
       }
    }

    private void OnCollisionEnter(Collision collision)
    {

        Vector3 dir = collision.contacts[0].point - transform.position;
        dir = -dir.normalized;

        Rigidbody r = collision.gameObject.GetComponent<Rigidbody>();
        if (r)
            r.AddForce(dir*force);
    }
}