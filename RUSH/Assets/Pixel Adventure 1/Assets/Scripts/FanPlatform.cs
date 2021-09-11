using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanPlatform : MonoBehaviour
{
    Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ani.Play("Fan_run");
        }
    }
}
