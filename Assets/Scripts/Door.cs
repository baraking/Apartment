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
        if (this.gameObject.name.Contains("Left"))
        {
            animator.Play("LeftDoorOpen");
        }
        else if (this.gameObject.name.Contains("Right"))
        {
            animator.Play("RightDoorOpen");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.gameObject.name.Contains("Left"))
        {
            animator.Play("LeftDoorClose");
        }
        else if (this.gameObject.name.Contains("Right"))
        {
            animator.Play("RightDoorClose");
        }
    }
}
