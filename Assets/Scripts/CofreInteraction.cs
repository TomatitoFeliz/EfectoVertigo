using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreInteraction : MonoBehaviour
{
    [SerializeField]
    Animator cofreAnimator;
    [SerializeField]
    Animator keyAnimator;

    public bool abierto = false;

    private void Start()
    {
        cofreAnimator = GameObject.Find("Cofre").GetComponent<Animator>();
        keyAnimator = GameObject.Find("Key").GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "area")
        {

            UnityEngine.Debug.Log("Estoy en el área");
            if (Input.GetKeyDown(KeyCode.E))
            {
                abierto = true;
                cofreAnimator.Play("cofre");
                keyAnimator.Play("PickUp");
            }
        }
    }
}
