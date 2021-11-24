using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjeto : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private bool moved;
    Animator m_Animator;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

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
        float force = 15000;

        Vector3 dir = collision.contacts[0].point - transform.position;
        dir = -dir.normalized;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(dir*force);
    }
}