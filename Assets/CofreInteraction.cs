using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreInteraction : MonoBehaviour
{
    [SerializeField]
    AnimationClip clipCofre;
    [SerializeField]
    Animation cofreAnimation;
    [SerializeField]
    GameObject cofre;

    private void Start()
    {
        cofreAnimation = cofre.GetComponent<Animation>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "area")
        {

            UnityEngine.Debug.Log("Estoy en el área");
            if (Input.GetKeyDown(KeyCode.E))
            {
                cofreAnimation.clip = clipCofre;
                cofreAnimation.Play();
            }
        }
    }
}
