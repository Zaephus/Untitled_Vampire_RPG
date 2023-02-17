using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;

    private float horizontal;
    private float vertical;

    private Rigidbody2D body;
    private Weapon weapon;

    private Vector2 velocity;

    private Vector3 mouseDir;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
        weapon = GetComponent<Weapon>();
        weapon.OnStart();
    }

    private void Update() {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        mouseDir = InputManager.MousePosition - transform.position;

        velocity = new Vector2(horizontal, vertical).normalized * moveSpeed;

        if(weapon != null) {
            weapon.OnUpdate();
        }

    }

    private void FixedUpdate() {

        body.velocity = velocity;
    } 
}
