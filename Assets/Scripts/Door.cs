using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] public GameObject gameObject;

    public Transform doorAxis;

    void Start()
    {
        if (doorAxis == null)
            doorAxis = this.transform.GetChild(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("LeftDoorOpen");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("LeftDoorClose");
    }
}
