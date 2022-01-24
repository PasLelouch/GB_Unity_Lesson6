using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private CharacterController controller;
    [SerializeField] private float Jumpspeed;
    private bool groundedPlayer;
    public bool isWalking;
    public Animator anim;
    Vector3 move;
    float gravityValue = -9.81f;
    AudioSource m_AudioSource;

    void Start()
    {
        anim = GetComponent<Animator>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       


        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && move.y < 0)
        {
            move.y = 0f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");



        move = transform.right * x + transform.forward * z;



        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {

            move.y += Mathf.Sqrt(Jumpspeed * -3.0f * gravityValue);

        }
        move.y += gravityValue * Time.deltaTime;
        controller.Move(move * Speed * Time.deltaTime);


    }

    void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);

        bool isWalking = hasHorizontalInput || hasVerticalInput;
        anim.SetBool("IsWalking", isWalking);

        if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop();
        }
    }
}
