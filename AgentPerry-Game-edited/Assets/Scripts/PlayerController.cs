using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour {
  public Animator animator;
  public float speed = 5f;
  public float jumpSpeed = 10f;
  private float movement = 0f;
  private Rigidbody2D rigidBody;
  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
  }
  
  // Update is called once per frame
  void Update () {
    movement = Input.GetAxis ("Horizontal");
    animator.SetFloat("Speed", Mathf.Abs(movement));

    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    } 
    else {
      rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
    }
    if(Input.GetButtonDown ("Jump")){
      rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
      animator.SetBool("IsJumping", true);
    }
  }
  public void OnLanding ()
  {
    animator.SetBool("IsJumping", false);
  }
}