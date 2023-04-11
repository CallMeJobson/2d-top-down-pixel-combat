using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] private float moveSpeed = 1f;
  private PlayerControls playerControls;
  private Vector2 movement;
  private Rigidbody2D rb;

  private void Awake() {
    playerControls = new PlayerControls();
    rb = GetComponent<Rigidbody2D>();
  }

  private void OnEnable() {
    //This is part of the new unity input system
    playerControls.Enable();
  }

// update is good for player input
  private void Update() {
    PlayerInput();

  }

  private void PlayerInput() {
    movement = playerControls.Movement.Move.ReadValue<Vector2>();

    
  }

  // Good for Physics 
  private void FixedUpdate() {
    Move();
  }

  private void Move(){
    rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
  }



  

}
