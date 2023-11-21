using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAnimation : MonoBehaviour
{
    [SerializeField]
    Animator cameraAnimator;
    public CofreInteraction cofreInteraction;

    float timer = 6f;

    private void Start()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMovement>().enabled = false;
        cofreInteraction = FindObjectOfType<CofreInteraction>();
        cameraAnimator = GameObject.Find("Main Camera").GetComponent<Animator>();
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().enabled = true;
        }
        if (cofreInteraction.abierto == true)
        {
            GameObject.Find("Main Camera").GetComponent<Animator>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<CameraMovement>().enabled = false;
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
            cameraAnimator.Play("PickUpCameraAnimation");
        }
    }
}
