using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private GameObject swoosh;

    [SerializeField]
    private float moveSpeed;

    private float horizontal;
    private float vertical;

    private Rigidbody2D body;

    private Vector2 velocity;

    private Vector3 mouseDir;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update() {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mouseDir = new Vector3(mouseDir.x, mouseDir.y, 0).normalized;

        swoosh.transform.position = transform.position + mouseDir;

        velocity = new Vector2(horizontal, vertical).normalized * moveSpeed;

    }

    private void FixedUpdate() {

        body.velocity = velocity;
    } 
}
