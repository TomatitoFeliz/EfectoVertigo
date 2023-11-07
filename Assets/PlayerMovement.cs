using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 playerMovementInput;
    private Vector2 playerMouseInput;
    public float mouseSesistivity = 5f;
    public bool puedeAbrir = false;
    Animator cofreAnimator;
    AnimationClip clipCofre;
    [SerializeField] private Rigidbody playerBody;
    [Space]
    [SerializeField] private float speed;
    [SerializeField] Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        cofreAnimator = GameObject.Find ("Cofre").GetComponent<Animator> ();
    }
    private void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal") * 2, 0f, Input.GetAxis("Vertical") * 2);
        playerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        MovePlayer();

        if (playerMovementInput.x != 0 || playerMovementInput.z > 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    private void MovePlayer()
    {
        Vector3 moveVector = transform.TransformDirection(playerMovementInput) * speed;
        playerBody.velocity = new Vector3(moveVector.x, playerBody.velocity.y, moveVector.z);

        transform.Rotate(0f, playerMouseInput.x * mouseSesistivity, 0f);

        if (puedeAbrir == true && Input.GetKeyDown(KeyCode.E))
            {
                UnityEngine.Debug.Log("me arde el ano");
                cofreAnimator.Play("Armature|ArmatureAction");
            puedeAbrir = false;
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("joder que bueno esta el burro de shrek");
        puedeAbrir = true;

    }

    private void OnTriggerExit(Collider other)
    {

        puedeAbrir = false;
   
    }       

}           
            