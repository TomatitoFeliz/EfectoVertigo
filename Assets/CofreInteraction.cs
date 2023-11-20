using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreInteraction : MonoBehaviour
{
    [SerializeField]
    Animator cofreAnimator;

    private void Start()
    {
        cofreAnimator = GameObject.Find("cofre").GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "area")
        {

            UnityEngine.Debug.Log("Estoy en el área");
            if (Input.GetKeyDown(KeyCode.E))
            {
                cofreAnimator.Play("cofre");
            }
        }
    }
}
