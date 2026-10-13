using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plyr_Movement : MonoBehaviour
{ //NOTE: Comments are more common compared to previous labs and scripts to make it easier to refer to and reuse in future contexts.
    Vector2 MoveInput; //calls for vector2 input
    Rigidbody2D rb; //calls for player rigidbody
    [SerializeField] float MoveSpd = 5f; //sets multiplied speed for player found in run

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //gets rigidbody for player
    }
    void Update()
    {
        Run(); //calls for run down below.
    }
    void OnMove(InputValue value)
    {
        MoveInput = value.Get<Vector2>(); //reads for player input
        //print(MoveInput); //debug test for input
    }
    void Run()
    { 
        Vector2 PlayerVel = new Vector2(MoveInput.x * MoveSpd, rb.linearVelocity.y); //sets player velocity based on input and rigidbody (is also put in update)
        rb.linearVelocity = PlayerVel; //sets player velocity based on input (is also put in update)
    }
}
