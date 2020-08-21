using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{
    [SerializeField] public GameObject tvScreen;

    private void Start()
    {
        tvScreen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        tvScreen.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        tvScreen.SetActive(false);
    }
}
