using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dnor : MonoBehaviour
{
    [SerializeField] private Animator dooranim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dooranim.SetBool("dooropen", true);
        }
    }
}