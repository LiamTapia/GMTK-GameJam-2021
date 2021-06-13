using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour
{
    public CharacterController player;
    //public GameObject player;
    public float speed = 5f;

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    private Animator animator;
    private bool enabled;
    private int health = 1;
    private Transform position;
    public string nextLevel;

    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        enabled = true;
        position = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enabled){
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical   = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;

            if(player.isGrounded)
            {
                moveDirection.x = horizontal*speed;
                moveDirection.z = vertical*speed;

                if(horizontal != 0 || vertical !=0){
                    animator.SetBool("isRunning", true);
                } else{
                    animator.SetBool("isRunning", false);
                }
                
                //if(Input.GetButton("Jump"))
                //    moveDirection.y = jumpSpeed;
            }
            
            moveDirection.y -= gravity * Time.deltaTime;
            player.Move(moveDirection * Time.deltaTime);
        }

        if((health == 0) || position.position.y < -20){
                FindObjectOfType<GameManager>().Restart();
            }
    }

    public void toggleEnabled() {
        enabled = !enabled;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("bullet") || other.CompareTag("ball")){
            if(health>0){
                health -= 1;
            }
        }
        if(other.CompareTag("finalNivel")){
            ChangeLevel();
        }        
    }

    public void ChangeLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
